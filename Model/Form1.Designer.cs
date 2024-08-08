
using System;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.Capture = new System.Windows.Forms.Button();
            this.Face = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.Train = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faceCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FaceName = new System.Windows.Forms.TextBox();
            this.Navigate_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCapture.Location = new System.Drawing.Point(24, 32);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(964, 641);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            this.picCapture.Click += new System.EventHandler(this.picCapture_Click);
            // 
            // Capture
            // 
            this.Capture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Capture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Capture.Location = new System.Drawing.Point(1115, 46);
            this.Capture.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(195, 39);
            this.Capture.TabIndex = 1;
            this.Capture.Text = "1.Camera";
            this.Capture.UseVisualStyleBackColor = false;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // Face
            // 
            this.Face.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Face.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Face.Location = new System.Drawing.Point(1127, 131);
            this.Face.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(200, 34);
            this.Face.TabIndex = 2;
            this.Face.Text = "2.Face Detection";
            this.Face.UseVisualStyleBackColor = false;
            this.Face.Click += new System.EventHandler(this.Face_Click);
            // 
            // picDetected
            // 
            this.picDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDetected.Location = new System.Drawing.Point(800, 32);
            this.picDetected.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(188, 180);
            this.picDetected.TabIndex = 3;
            this.picDetected.TabStop = false;
            this.picDetected.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPerson.Location = new System.Drawing.Point(1140, 260);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(170, 31);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "3.Save Name";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonName.Location = new System.Drawing.Point(1137, 190);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4, 23, 4, 2);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(185, 22);
            this.txtPersonName.TabIndex = 5;
            this.txtPersonName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged);
            // 
            // Train
            // 
            this.Train.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Train.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Train.Location = new System.Drawing.Point(1122, 345);
            this.Train.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(200, 41);
            this.Train.TabIndex = 6;
            this.Train.Text = "4.Trained Images";
            this.Train.UseVisualStyleBackColor = false;
            this.Train.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1224, 505);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 168);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(1007, 505);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 168);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(453, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(129, 20);
            this.Title.TabIndex = 10;
            this.Title.Text = "Face Detector";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1152, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recognization";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // faceCount
            // 
            this.faceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faceCount.Location = new System.Drawing.Point(295, 716);
            this.faceCount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.faceCount.Name = "faceCount";
            this.faceCount.Size = new System.Drawing.Size(52, 22);
            this.faceCount.TabIndex = 12;
            this.faceCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 719);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Faces Count";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Persons Present in the Screen";
            // 
            // FaceName
            // 
            this.FaceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FaceName.Location = new System.Drawing.Point(657, 719);
            this.FaceName.Name = "FaceName";
            this.FaceName.Size = new System.Drawing.Size(176, 22);
            this.FaceName.TabIndex = 15;
            this.FaceName.TextChanged += new System.EventHandler(this.FaceName_TextChanged);
            // 
            // Navigate_Click
            // 
            this.Navigate_Click.Location = new System.Drawing.Point(1007, 712);
            this.Navigate_Click.Name = "Navigate_Click";
            this.Navigate_Click.Size = new System.Drawing.Size(98, 25);
            this.Navigate_Click.TabIndex = 17;
            this.Navigate_Click.Text = "Object";
            this.Navigate_Click.UseVisualStyleBackColor = true;
            this.Navigate_Click.Click += new System.EventHandler(this.Navigate_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1446, 786);
            this.Controls.Add(this.Navigate_Click);
            this.Controls.Add(this.FaceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faceCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Capture);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Detector";
            this.Load += new System.EventHandler(this.Maximize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Maximize_Load(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void txtPersonName_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();  
        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button Capture;
        private System.Windows.Forms.Button Face;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtPersonName; 
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FaceName;
        private System.Windows.Forms.Button Navigate_Click;
    }
}

