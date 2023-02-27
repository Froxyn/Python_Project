/*
 * Kullanıcı: talha
 * Tarih: 8.09.2021
 * Zaman: 20:16
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kayıt
{
	/// <summary>
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			InitializeComponent();
			
			// TODO
	}
		void Kayıt_olClick(object sender, EventArgs e)
		{
			try {
				//Oluşturulan Stringler
				string isim_2 = isim_1.Text;
				string sifre_2 = sifre_1.Text;
				string eposta_2 = eposta_1.Text;
				string dogum_2 = dogum_1.Text;
				string kayıtlı_kişi = isim_2 + " / " + sifre_2 + " / " + eposta_2 + " / " + dogum_2;
				//
				//Kullanıcı Datası İsmi Oluşturma
				Random rastgele = new Random();
				Random rastgele1 = new Random();
				Random rastgele2 = new Random();
				int sayi = rastgele.Next(57483000,2147483646);
				int sayi1 = rastgele1.Next(35682000,2147483646);
				int sayi2 = rastgele2.Next(29243050,2147483646);
				//
				//Eğer Boşta Bırakırsa Hata
				if (isim_1.Text=="" || sifre_1.Text=="" || eposta_1.Text=="") {
					MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Bilgilendirme Penceresi");
				//Kullanıcı Datasını Kayıt Etme
				} else {
					string dosya_yolu=@"C:\Users\talha\Documents\SharpDevelop Projects\Kayıt\" + sayi + sayi1 + sayi2 + "_user_data" + ".txt";
        			FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
        			StreamWriter sw = new StreamWriter(fs);
        			sw.WriteLine(kayıtlı_kişi);
        			sw.Flush();
        			sw.Close();
        			fs.Close();
            		//
					MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgilendirme Penceresi");
					}
				//
			} catch (Exception) {
				MessageBox.Show("Lütfen Tekrar Deneyiniz!", "HATA!");
			}
			}
		void Gizle_gösterCheckedChanged(object sender, EventArgs e)
		{
			if (gizle_göster.CheckState==CheckState.Checked) {
				sifre_1.UseSystemPasswordChar = true;
				gizle_göster.Text="Gizle";
			} else if (gizle_göster.CheckState==CheckState.Unchecked){
				sifre_1.UseSystemPasswordChar = false;
				gizle_göster.Text="Göster";
			}
		}
		}
	}