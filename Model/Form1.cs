using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO; 
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        #region Variables
        int testid = 0;
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;

        CascadeClassifier facecascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;

        List<string> PersonsNames = new List<string>();


        #endregion

        public Form1()
        {
            InitializeComponent();
        } 

        private void Capture_Click(object sender, EventArgs e)
        {
            
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            //videoCapture.ImageGrabbed += ProcessFrame;
            Application.Idle += ProcessFrame;
            // videoCapture.Start();
            btnAddPerson.Enabled = false;
            Train.Enabled = false;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

               
                if (facesDetectionEnabled)
                {

                    
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                   
                    CvInvoke.EqualizeHist(grayImage, grayImage);                   
                    Rectangle[] faces = facecascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            
                            // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDetected.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                   
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (txtPersonName.InvokeRequired)
                            {
                                txtPersonName.Invoke(new ThreadStart(delegate
                                {
                                    txtPersonName.Enabled = true;
                                }));
                            }

                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox1.Image = grayFaceResult.Bitmap;
                                pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);

                                    if (result.Label != -1 && result.Distance < 2000)
                                    {                                
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                    }
                                
                                else
                                {                                    
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }

                               
                            }
                            faceCount.Text = faces.Length.ToString();                            

                            FaceName.Text = FontFace.HersheyComplex.ToString();
                        }
                    }
                }

               
                picCapture.Image = currentFrame.Bitmap;
            }

            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void Face_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
            btnAddPerson.Enabled = true;
            Train.Enabled = false;
            Capture.Enabled = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {

            txtPersonName.Enabled = false;
            //Save.Enabled = true;
            EnableSaveImage = true;
            btnAddPerson.Enabled = true;
            Train.Enabled = true;
            Capture.Enabled = false;
            Face.Enabled = false;
            try
            {
                if (string.IsNullOrEmpty(txtPersonName.Text))
                {
                    txtPersonName.Enabled = true;
                    MessageBox.Show("Please input Your name to add face");
                }

            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
            Capture.Enabled = false;
            Face.Enabled = false;
            btnAddPerson.Enabled = false;
         //   Train.Enabled = true;

        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                

                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void picCapture_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             //
        }

        private void FaceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Navigate_Click_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}