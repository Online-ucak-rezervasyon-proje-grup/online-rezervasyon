
namespace kullanici_girisi
{
    partial class Giris
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
            this.b_giris = new System.Windows.Forms.Button();
            this.b_cikisi = new System.Windows.Forms.Button();
            this.t_k_adi = new System.Windows.Forms.TextBox();
            this.t_parola = new System.Windows.Forms.TextBox();
            this.l_k_adi = new System.Windows.Forms.Label();
            this.l_parola = new System.Windows.Forms.Label();
            this.b_kayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_giris
            // 
            this.b_giris.BackColor = System.Drawing.Color.Lime;
            this.b_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_giris.Location = new System.Drawing.Point(328, 233);
            this.b_giris.Margin = new System.Windows.Forms.Padding(4);
            this.b_giris.Name = "b_giris";
            this.b_giris.Size = new System.Drawing.Size(141, 46);
            this.b_giris.TabIndex = 0;
            this.b_giris.Text = "Giriş";
            this.b_giris.UseVisualStyleBackColor = false;
            this.b_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_cikisi
            // 
            this.b_cikisi.BackColor = System.Drawing.Color.Red;
            this.b_cikisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_cikisi.Location = new System.Drawing.Point(504, 233);
            this.b_cikisi.Margin = new System.Windows.Forms.Padding(4);
            this.b_cikisi.Name = "b_cikisi";
            this.b_cikisi.Size = new System.Drawing.Size(141, 46);
            this.b_cikisi.TabIndex = 1;
            this.b_cikisi.Text = "Çıkış";
            this.b_cikisi.UseVisualStyleBackColor = false;
            this.b_cikisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // t_k_adi
            // 
            this.t_k_adi.Location = new System.Drawing.Point(328, 113);
            this.t_k_adi.Margin = new System.Windows.Forms.Padding(4);
            this.t_k_adi.Name = "t_k_adi";
            this.t_k_adi.Size = new System.Drawing.Size(312, 22);
            this.t_k_adi.TabIndex = 2;
            // 
            // t_parola
            // 
            this.t_parola.Location = new System.Drawing.Point(328, 182);
            this.t_parola.Margin = new System.Windows.Forms.Padding(4);
            this.t_parola.Name = "t_parola";
            this.t_parola.PasswordChar = '*';
            this.t_parola.Size = new System.Drawing.Size(312, 22);
            this.t_parola.TabIndex = 3;
            // 
            // l_k_adi
            // 
            this.l_k_adi.AutoSize = true;
            this.l_k_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_k_adi.Location = new System.Drawing.Point(324, 89);
            this.l_k_adi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_k_adi.Name = "l_k_adi";
            this.l_k_adi.Size = new System.Drawing.Size(101, 20);
            this.l_k_adi.TabIndex = 4;
            this.l_k_adi.Text = "Kullanıcı Adı";
            // 
            // l_parola
            // 
            this.l_parola.AutoSize = true;
            this.l_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_parola.Location = new System.Drawing.Point(324, 158);
            this.l_parola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_parola.Name = "l_parola";
            this.l_parola.Size = new System.Drawing.Size(57, 20);
            this.l_parola.TabIndex = 5;
            this.l_parola.Text = "Parola";
            // 
            // b_kayit
            // 
            this.b_kayit.BackColor = System.Drawing.Color.Yellow;
            this.b_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_kayit.Location = new System.Drawing.Point(328, 325);
            this.b_kayit.Margin = new System.Windows.Forms.Padding(4);
            this.b_kayit.Name = "b_kayit";
            this.b_kayit.Size = new System.Drawing.Size(317, 46);
            this.b_kayit.TabIndex = 6;
            this.b_kayit.Text = "Kayıt Ol";
            this.b_kayit.UseVisualStyleBackColor = false;
            this.b_kayit.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kullanici_girisi.Properties.Resources.uyegiris;
            this.pictureBox1.Location = new System.Drawing.Point(27, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_kayit);
            this.Controls.Add(this.l_parola);
            this.Controls.Add(this.l_k_adi);
            this.Controls.Add(this.t_parola);
            this.Controls.Add(this.t_k_adi);
            this.Controls.Add(this.b_cikisi);
            this.Controls.Add(this.b_giris);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_giris;
        private System.Windows.Forms.Button b_cikisi;
        private System.Windows.Forms.TextBox t_k_adi;
        private System.Windows.Forms.TextBox t_parola;
        private System.Windows.Forms.Label l_k_adi;
        private System.Windows.Forms.Label l_parola;
        private System.Windows.Forms.Button b_kayit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}