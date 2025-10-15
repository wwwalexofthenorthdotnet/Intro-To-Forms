﻿namespace Intro_To_Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.imgThwomp = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgThwomp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(401, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 32);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(346, 47);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(182, 13);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Click on the button or the Picture box";
            // 
            // imgThwomp
            // 
            this.imgThwomp.Image = ((System.Drawing.Image)(resources.GetObject("imgThwomp.Image")));
            this.imgThwomp.Location = new System.Drawing.Point(231, 141);
            this.imgThwomp.Name = "imgThwomp";
            this.imgThwomp.Size = new System.Drawing.Size(100, 111);
            this.imgThwomp.TabIndex = 2;
            this.imgThwomp.TabStop = false;
            this.imgThwomp.Visible = false;
            this.imgThwomp.Click += new System.EventHandler(this.imgThwomp_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(398, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Not Clicked";
            // 
            // btnQuit
            // 
            this.btnQuit.Enabled = false;
            this.btnQuit.Location = new System.Drawing.Point(409, 321);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.imgThwomp);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Controls, Events, and Properties";
            ((System.ComponentModel.ISupportInitialize)(this.imgThwomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgThwomp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnQuit;
    }
}

