
namespace WindowsFormsApp11
{
    partial class Form2
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
            this.objpicture1 = new System.Windows.Forms.PictureBox();
            this.btnclick1 = new System.Windows.Forms.Button();
            this.btnclick2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objpicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // objpicture1
            // 
            this.objpicture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.objpicture1.Location = new System.Drawing.Point(13, 13);
            this.objpicture1.Name = "objpicture1";
            this.objpicture1.Size = new System.Drawing.Size(1087, 587);
            this.objpicture1.TabIndex = 0;
            this.objpicture1.TabStop = false;
            // 
            // btnclick1
            // 
            this.btnclick1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnclick1.Location = new System.Drawing.Point(1151, 31);
            this.btnclick1.Name = "btnclick1";
            this.btnclick1.Size = new System.Drawing.Size(137, 39);
            this.btnclick1.TabIndex = 1;
            this.btnclick1.Text = "Camera";
            this.btnclick1.UseVisualStyleBackColor = false;
            this.btnclick1.Click += new System.EventHandler(this.btnclick1_Click);
            // 
            // btnclick2
            // 
            this.btnclick2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclick2.Location = new System.Drawing.Point(1151, 105);
            this.btnclick2.Name = "btnclick2";
            this.btnclick2.Size = new System.Drawing.Size(137, 36);
            this.btnclick2.TabIndex = 2;
            this.btnclick2.Text = "DetectObject";
            this.btnclick2.UseVisualStyleBackColor = false;
            this.btnclick2.Click += new System.EventHandler(this.btnclick2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1374, 719);
            this.Controls.Add(this.btnclick2);
            this.Controls.Add(this.btnclick1);
            this.Controls.Add(this.objpicture1);
            this.Name = "Form2";
            this.Text = "ObjectDetector";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objpicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox objpicture1;
        private System.Windows.Forms.Button btnclick1;
        private System.Windows.Forms.Button btnclick2;
    }
}