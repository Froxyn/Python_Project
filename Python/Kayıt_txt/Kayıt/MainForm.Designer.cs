/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: talha
 * Tarih: 8.09.2021
 * Zaman: 20:16
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace Kayıt
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label isim;
		private System.Windows.Forms.TextBox isim_1;
		private System.Windows.Forms.Label eposta;
		private System.Windows.Forms.TextBox eposta_1;
		private System.Windows.Forms.DateTimePicker dogum_1;
		private System.Windows.Forms.Label dogum;
		private System.Windows.Forms.Button kayıt_ol;
		private System.Windows.Forms.Label sifre;
		private System.Windows.Forms.TextBox sifre_1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.CheckBox gizle_göster;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.isim = new System.Windows.Forms.Label();
			this.isim_1 = new System.Windows.Forms.TextBox();
			this.eposta = new System.Windows.Forms.Label();
			this.eposta_1 = new System.Windows.Forms.TextBox();
			this.dogum_1 = new System.Windows.Forms.DateTimePicker();
			this.dogum = new System.Windows.Forms.Label();
			this.kayıt_ol = new System.Windows.Forms.Button();
			this.sifre = new System.Windows.Forms.Label();
			this.sifre_1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.gizle_göster = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// isim
			// 
			this.isim.BackColor = System.Drawing.SystemColors.Window;
			this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.isim.ForeColor = System.Drawing.Color.Black;
			this.isim.Location = new System.Drawing.Point(43, 9);
			this.isim.Name = "isim";
			this.isim.Size = new System.Drawing.Size(176, 15);
			this.isim.TabIndex = 0;
			this.isim.Text = "Lütfen KullanıcıAdınızı Giriniz";
			this.isim.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// isim_1
			// 
			this.isim_1.Location = new System.Drawing.Point(42, 27);
			this.isim_1.Name = "isim_1";
			this.isim_1.Size = new System.Drawing.Size(177, 20);
			this.isim_1.TabIndex = 1;
			// 
			// eposta
			// 
			this.eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.eposta.Location = new System.Drawing.Point(41, 111);
			this.eposta.Name = "eposta";
			this.eposta.Size = new System.Drawing.Size(178, 16);
			this.eposta.TabIndex = 4;
			this.eposta.Text = "Lütfen E-Postanızı Giriniz";
			// 
			// eposta_1
			// 
			this.eposta_1.Location = new System.Drawing.Point(41, 130);
			this.eposta_1.Name = "eposta_1";
			this.eposta_1.Size = new System.Drawing.Size(178, 20);
			this.eposta_1.TabIndex = 5;
			// 
			// dogum_1
			// 
			this.dogum_1.Location = new System.Drawing.Point(40, 182);
			this.dogum_1.Name = "dogum_1";
			this.dogum_1.Size = new System.Drawing.Size(200, 20);
			this.dogum_1.TabIndex = 6;
			// 
			// dogum
			// 
			this.dogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dogum.Location = new System.Drawing.Point(41, 163);
			this.dogum.Name = "dogum";
			this.dogum.Size = new System.Drawing.Size(199, 16);
			this.dogum.TabIndex = 7;
			this.dogum.Text = "Lütfen Doğum Tarihinizi Giriniz";
			// 
			// kayıt_ol
			// 
			this.kayıt_ol.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.kayıt_ol.Location = new System.Drawing.Point(194, 223);
			this.kayıt_ol.Name = "kayıt_ol";
			this.kayıt_ol.Size = new System.Drawing.Size(75, 23);
			this.kayıt_ol.TabIndex = 8;
			this.kayıt_ol.Text = "Kayıt Ol";
			this.kayıt_ol.UseVisualStyleBackColor = false;
			this.kayıt_ol.Click += new System.EventHandler(this.Kayıt_olClick);
			// 
			// sifre
			// 
			this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sifre.Location = new System.Drawing.Point(44, 59);
			this.sifre.Name = "sifre";
			this.sifre.Size = new System.Drawing.Size(176, 15);
			this.sifre.TabIndex = 9;
			this.sifre.Text = "Lütfen Şifrenizi Giriniz";
			// 
			// sifre_1
			// 
			this.sifre_1.Location = new System.Drawing.Point(43, 77);
			this.sifre_1.Multiline = true;
			this.sifre_1.Name = "sifre_1";
			this.sifre_1.PasswordChar = '*';
			this.sifre_1.Size = new System.Drawing.Size(178, 20);
			this.sifre_1.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 33);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(4, 61);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 33);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(4, 113);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 34);
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(4, 165);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(33, 33);
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// gizle_göster
			// 
			this.gizle_göster.Location = new System.Drawing.Point(222, 78);
			this.gizle_göster.Name = "gizle_göster";
			this.gizle_göster.Size = new System.Drawing.Size(57, 19);
			this.gizle_göster.TabIndex = 15;
			this.gizle_göster.Text = "Göster";
			this.gizle_göster.UseVisualStyleBackColor = true;
			this.gizle_göster.CheckedChanged += new System.EventHandler(this.Gizle_gösterCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(282, 261);
			this.Controls.Add(this.gizle_göster);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.sifre_1);
			this.Controls.Add(this.sifre);
			this.Controls.Add(this.kayıt_ol);
			this.Controls.Add(this.dogum);
			this.Controls.Add(this.dogum_1);
			this.Controls.Add(this.eposta_1);
			this.Controls.Add(this.eposta);
			this.Controls.Add(this.isim_1);
			this.Controls.Add(this.isim);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(298, 300);
			this.MinimumSize = new System.Drawing.Size(298, 300);
			this.Name = "MainForm";
			this.Text = "Kayıt Menüsü";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
