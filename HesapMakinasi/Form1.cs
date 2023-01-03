using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char islem;
        bool ekranTemizlenecekmi;
        int ilkSayi;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRakam1_Click(object sender, EventArgs e)
        {
            if(ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if(label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1"; 
        }

        private void btnRakam2_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void btnRakam3_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void btnRakam4_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";
        }

        private void btnRakam5_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void btnRakam6_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void btnRakam7_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void btnRakam8_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void btnRakam9_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekmi == true)
            {
                label1.Text = "";
                ekranTemizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void btnRakam0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "0";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = '+';
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = '-';
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = '*';
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = '/';
        }
        private void btnKare_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = 'k';
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            int sonuc;
            int ikinciSayi = Convert.ToInt32(label1.Text);
            switch (islem)
            {
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = ilkSayi / ikinciSayi;
                    break;
                case 'k':
                    sonuc = ilkSayi * ilkSayi;
                    break;
                case 'y':
                    sonuc = ilkSayi * (ikinciSayi/ 100);
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            ekranTemizlenecekmi = true;
            ilkSayi = Convert.ToInt32(label1.Text);
            islem = 'y';
        }
    }
}
