﻿namespace PruebaGithub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGrabar = new Button();
            btnCambiosReq1 = new Button();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(192, 100);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(151, 36);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCambiosReq1
            // 
            btnCambiosReq1.Location = new Point(201, 247);
            btnCambiosReq1.Name = "btnCambiosReq1";
            btnCambiosReq1.Size = new Size(151, 36);
            btnCambiosReq1.TabIndex = 1;
            btnCambiosReq1.Text = "CambiosReq1";
            btnCambiosReq1.UseVisualStyleBackColor = true;
            btnCambiosReq1.Click += btnCambiosReq1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 375);
            Controls.Add(btnCambiosReq1);
            Controls.Add(btnGrabar);
            Name = "Form1";
            Text = "Prueba GITHUB";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGrabar;
        private Button btnCambiosReq1;
    }
}
