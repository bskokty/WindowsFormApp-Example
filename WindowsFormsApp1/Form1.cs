using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
      
        private void birinci_islem_Click(object sender, EventArgs e)
        {
            if (birinciSayi.Text!="" && ikinciSayi.Text != "" && ucuncuSayi.Text != "")
            {
                int birinci = Convert.ToInt32(birinciSayi.Text);
                int ikinci = Convert.ToInt32(ikinciSayi.Text);
                int ucuncu = Convert.ToInt32(ucuncuSayi.Text);

                int sonuc = (birinci + ikinci) * ucuncu;
                labelSonuc.Text = " (" + birinci.ToString() + " + " + ikinci.ToString() + ")*" + ucuncu.ToString() + " = " + sonuc.ToString();
                SonucText.Text = sonuc.ToString();
                labelSonuc.Visible = true;
                SonucText.Enabled = true;
            }
            else
            {
                labelSonuc.Text = "Lütfen bir sayı giriniz.";
                labelSonuc.Visible = true;
            }
         
        }

        private void birinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayı girisi yapılmasını sağlıyorum.
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ikinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void ucuncuSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    sayiListesi.Items.Add("zig");
               
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    sayiListesi.Items.Add("zag");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    sayiListesi.Items.Add("zigzag");
                }
                else
                sayiListesi.Items.Add(i);
            }
        }


        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            mtrs.Text = "";
            if (SayiGiris.Text != "" && Convert.ToInt32(SayiGiris.Text)>0 && Convert.ToInt32(SayiGiris.Text)<16)
            {

                int x = Convert.ToInt32(SayiGiris.Text);

                int[,] carpimSayi = new int[x, x];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        carpimSayi[i, j] = (i + 1) * (j + 1);
                    }

                }
                mtrs.Visible = true;
                for (int k = 0; k < x + 1; k++)
                {
                    mtrs.Text += "  " + k;

                }
                mtrs.Text += "\r\n";
                for (int i = 0; i < x; i++)
                {
                    mtrs.Text += (i + 1);
                    for (int j = 0; j < x; j++)
                    {

                        mtrs.Text += "  " + carpimSayi[i, j];
                    }

                    mtrs.Text += "\r\n";
                }
            }
            else
            {
                mtrs.Visible = true;
                mtrs.Text += "Lütfen 1 ile 15 arasında bir sayı giriniz.";
            }
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {

                OpenFileDialog openFile1 = new OpenFileDialog();
                openFile1.ShowDialog();
            using (StreamReader reader = new StreamReader(openFile1.FileName))
            {
                string line = reader.ReadToEnd();
                string line1 = line.Replace("\r\n", " ");
                string line2 = line1.Replace("\t", " ");
                string line3 = line2.Replace(",", ".");
                string[] dizi = line3.Split(' ');
                List<string> diziSon = new List<string>();
                int count = 0;
                foreach (var item in dizi)
                {
                    if (item != "")
                        diziSon.Add(item);
                        count++;
                }
                List<decimal> sayilar = new List<decimal>();
                foreach (var item in diziSon)
                {
                    sayilar.Add(Convert.ToDecimal(item));
                }
                sayilar.Sort();
                foreach (var item in sayilar)
                {
                    siralama.Items.Add(item);
                }
                
            }

        }
        public static int Fibonacci(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
        }
        private void btnFibo_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(fiboText.Text);
            
            FiboSonuc.Visible = true;
            FiboSonuc.Text=sayi+". Fibonacci Sayısı = "+ Fibonacci(sayi-1).ToString();
        }

      
    }
}
