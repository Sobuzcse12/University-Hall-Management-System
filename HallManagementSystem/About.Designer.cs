﻿namespace HallManagementSystem
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLevel
            // 
            this.aboutLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLevel.ForeColor = System.Drawing.Color.Navy;
            this.aboutLevel.Location = new System.Drawing.Point(12, 12);
            this.aboutLevel.Name = "aboutLevel";
            this.aboutLevel.Size = new System.Drawing.Size(406, 470);
            this.aboutLevel.TabIndex = 0;
            this.aboutLevel.Text = resources.GetString("aboutLevel.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HallManagementSystem.Properties.Resources.IMG_20140918_125213;
            this.pictureBox1.Location = new System.Drawing.Point(424, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aboutLevel);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aboutLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}