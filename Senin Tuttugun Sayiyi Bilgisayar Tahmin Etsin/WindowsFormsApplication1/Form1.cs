using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int tahmin = 0;
        int deneme_sayisi = 0;
        int alt_sinir;
        int ust_sinir;
        bool tahmin_edebilir = false;
        int onceki;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbAltSinir.Text = "0";
            tbUstSinir.Text = "100";
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            deneme_sayisi = 0;

            alt_sinir = int.Parse(tbAltSinir.Text);
            ust_sinir = int.Parse(tbUstSinir.Text);

            tahmin = (ust_sinir - alt_sinir) / 2 + alt_sinir;

            if (alt_sinir > ust_sinir)
            {
                MessageBox.Show("Alt sınır üst sınırdan büyük olamaz");
                tahmin_edebilir = false;
            }
            else if (alt_sinir == ust_sinir)
            {
                MessageBox.Show("Alt sınır üst sınıra eşit olamaz");
                tahmin_edebilir = false;
            }
            else
            {
                lblTahmin.Text = tahmin.ToString();
                deneme_sayisi++;
                lblDenemeSayisi.Text = deneme_sayisi.ToString();
                tahmin_edebilir = true;
            }
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (tahmin_edebilir)
            {
                ust_sinir = tahmin;
                onceki = tahmin;
                tahmin -= (ust_sinir - alt_sinir) / 2;

                if (onceki == tahmin)
                {
                    MessageBox.Show("Hile Yapma!");
                    return;
                }

                lblTahmin.Text = tahmin.ToString();
                deneme_sayisi++;
                lblDenemeSayisi.Text = deneme_sayisi.ToString();
            }
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            if (tahmin_edebilir)
            {
                alt_sinir = tahmin;
                onceki = tahmin;
                tahmin += (ust_sinir - alt_sinir) / 2;

                if (onceki == tahmin)
                {
                    MessageBox.Show("Hile Yapma");
                    return;
                }
                lblTahmin.Text = tahmin.ToString();
                deneme_sayisi++;
                lblDenemeSayisi.Text = deneme_sayisi.ToString();
            }
        }

        private void btnYenidenOyna_Click(object sender, EventArgs e)
        {
            deneme_sayisi = 0;
            lblDenemeSayisi.Text = deneme_sayisi.ToString();
            tahmin = 0;
            lblTahmin.Text = tahmin.ToString();
            tbAltSinir.Text = "0";
            tbUstSinir.Text = "100";
        }

        private void btnBildin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deneme_sayisi.ToString() + ". denemede bildin.");
        }
    }
}
