using System;

namespace School_Manager
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.EmpleadosBox = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UserAdminbtn = new System.Windows.Forms.Button();
            this.EmpCant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtCant = new System.Windows.Forms.Label();
            this.ArtAdminbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VentaBox = new System.Windows.Forms.Panel();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.EmpleadosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.VentaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpleadosBox
            // 
            this.EmpleadosBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmpleadosBox.Controls.Add(this.pictureBox4);
            this.EmpleadosBox.Controls.Add(this.UserAdminbtn);
            this.EmpleadosBox.Controls.Add(this.EmpCant);
            this.EmpleadosBox.Location = new System.Drawing.Point(613, 200);
            this.EmpleadosBox.Name = "EmpleadosBox";
            this.EmpleadosBox.Size = new System.Drawing.Size(197, 165);
            this.EmpleadosBox.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(60, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // UserAdminbtn
            // 
            this.UserAdminbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdminbtn.Location = new System.Drawing.Point(70, 114);
            this.UserAdminbtn.Name = "UserAdminbtn";
            this.UserAdminbtn.Size = new System.Drawing.Size(61, 39);
            this.UserAdminbtn.TabIndex = 4;
            this.UserAdminbtn.Text = "Ir";
            this.UserAdminbtn.UseVisualStyleBackColor = true;
            this.UserAdminbtn.Click += new System.EventHandler(this.Usuariobtn_Click);
            // 
            // EmpCant
            // 
            this.EmpCant.AutoSize = true;
            this.EmpCant.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCant.Location = new System.Drawing.Point(81, 80);
            this.EmpCant.Name = "EmpCant";
            this.EmpCant.Size = new System.Drawing.Size(32, 31);
            this.EmpCant.TabIndex = 3;
            this.EmpCant.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido Admin";
            // 
            // ArtCant
            // 
            this.ArtCant.AutoSize = true;
            this.ArtCant.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtCant.Location = new System.Drawing.Point(78, 80);
            this.ArtCant.Name = "ArtCant";
            this.ArtCant.Size = new System.Drawing.Size(32, 31);
            this.ArtCant.TabIndex = 5;
            this.ArtCant.Text = "0";
            // 
            // ArtAdminbtn
            // 
            this.ArtAdminbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtAdminbtn.Location = new System.Drawing.Point(64, 114);
            this.ArtAdminbtn.Name = "ArtAdminbtn";
            this.ArtAdminbtn.Size = new System.Drawing.Size(61, 39);
            this.ArtAdminbtn.TabIndex = 7;
            this.ArtAdminbtn.Text = "Ir";
            this.ArtAdminbtn.UseVisualStyleBackColor = true;
            this.ArtAdminbtn.Click += new System.EventHandler(this.ArtAdminbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // VentaBox
            // 
            this.VentaBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VentaBox.Controls.Add(this.pictureBox2);
            this.VentaBox.Controls.Add(this.ArtAdminbtn);
            this.VentaBox.Controls.Add(this.ArtCant);
            this.VentaBox.Location = new System.Drawing.Point(184, 203);
            this.VentaBox.Name = "VentaBox";
            this.VentaBox.Size = new System.Drawing.Size(197, 165);
            this.VentaBox.TabIndex = 1;
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbtn.Location = new System.Drawing.Point(888, 23);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(105, 33);
            this.Guardarbtn.TabIndex = 45;
            this.Guardarbtn.Text = "Salir";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1062, 642);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VentaBox);
            this.Controls.Add(this.EmpleadosBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.EmpleadosBox.ResumeLayout(false);
            this.EmpleadosBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.VentaBox.ResumeLayout(false);
            this.VentaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Panel EmpleadosBox;
        private System.Windows.Forms.Label EmpCant;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button UserAdminbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArtCant;
        private System.Windows.Forms.Button ArtAdminbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel VentaBox;
        private System.Windows.Forms.Button Guardarbtn;
    }
}