using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string JenisKelamin;
        string zodiak;
        string sifat;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnik_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtalamat_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void rblaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rblaki.Checked)
            {
                JenisKelamin = rblaki.Text;
                
            }
        }

    

        private void btnview_Click(object sender, EventArgs e)
        {
            

            string b = dtptanggal.Value.ToString("MM");
            string t = dtptanggal.Value.ToString("dd");
            int Bulan = Convert.ToInt32(b);
            int Tanggal = Convert.ToInt32(t);

         


            if (Bulan == 1)
            {
                if (Tanggal <= 19)
                {

                    zodiak = "Capricorn";
                }
                else
                {
                    zodiak = "Aquarius";
                }

            }
            else if (Bulan == 2)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Aquarius";
                }
                else
                {
                    zodiak = "Pisces";
                }
            }
            else if (Bulan == 3)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Pisces";
                }
                else
                {
                    zodiak = "Aries";
                }
            }
            else if (Bulan == 4)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Aries";
                }
                else
                {
                    zodiak = "Taurus";
                }

            }
            else if (Bulan == 5)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Taurus";
                }
                else
                {
                    zodiak = "Gemini";
                }

            }
            else if (Bulan == 6)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Gemini";
                }
                else
                {
                    zodiak = "Cancer";
                }

            }
            else if (Bulan == 7)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Cancer";
                }
                else
                {
                    zodiak = "Leo";
                }

            }
            else if (Bulan == 8)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Leo";
                }
                else
                {
                    zodiak = "Virgo";
                }

            }
            else if (Bulan == 9)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Virgo";
                }
                else
                {
                    zodiak = "Libra";
                }

            }
            else if (Bulan == 10)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Libra";
                }
                else
                {
                    zodiak = "Scorpio";
                }

            }
            else if (Bulan == 11)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Scoirpio";
                }
                else
                {
                    zodiak = "Sagitarius";
                }
            }
            else if (Bulan == 12)
            {
                if (Tanggal <= 19)
                {
                    zodiak = "Sagitarius";
                }
                else
                {
                    zodiak = "Capricon";
                }
            }

            if (zodiak == "Capricorn")
            {
                sifat = "Mempunyai rasa gengsi yang tinggi\nOrangnya sangat rajinLebih cenderung Pendiam\nMemiliki pendirian yang teguh\nCukup matrealis\nSenang memerintah orang lain\nAmbisius dalam mengejar target\nMampu mengordinasi sesuatu dengan baik";
            }
            else if (zodiak == "Aquarius")
            {
                sifat = "Dia seorang yang jenius\nMemiliki pembawaan diri yang sangat tenang\nCenderung sangat objektif dalam memihak\nPenuh dengan ide-ide kreatif\nMampu memahami sesuatu secara cepat";
            }
            else if (zodiak == "Pisces")
            {
                sifat = "Orangnya memiliki sisi sosial yang tinggi\nPenuh dengan rasa cinta\nSelalu berlaku praktis\nSelalu berpikir positif\nSuka berangan-angan";
            }
            else if (zodiak == "Aries")
            {
                sifat = "Orangnya sangat energik dan aktif\nMudah terpancing emosi\nImpulsif dan agresif\nAgak egois\nOrangnya tidak sabaran";
            }
            else if (zodiak == "Taurus")
            {
                sifat = "Orangnya cukup matrealis\nSetia dalam cinta\nKeras kepala\nSabar dan ramah\nMempunyai sifat toleransi yang tinggi\nCenderung pasif";
            }
            else if (zodiak == "Gemini")
            {
                sifat = "Mampu berkomunikasi dengan baik\nMudah terpengaruh dengan orang lain\nMerupakan pribadi yang aktif\nMudah gugup\nJiwa sosialnya sangat tinggi";
            }
            else if (zodiak == "Cancer")
            {
                sifat = "Merupakan pribadi yang setia\nSosok yang penuh perhatian\nMemiliki daya ingat yang kuat\nSulit memaafkan orang lain\nKondisi hati suka berubah - ubah";
            }
            else if (zodiak == "Leo")
            {
                sifat = "Orangnya suka memimpin\nMemiliki rasa percaya diri yang tinggi\nMurah hati dan dermawan\nSedikit congkak\nPenuh gaya dan aristokratis";
            }
            else if (zodiak == "Virgo")
            {
                sifat = "Pribadi yang suka menganalisa\nSangat rajin\nSelalu Berpikir logis\nBerkepala dingin\nOrangnya sederhana\nMemiliki sifat praktis dan kritis terhadap sesuatu";
            }
            else if (zodiak == "Libra")
            {
                sifat = "Pribadi yang suka menganalisa\nSangat rajin\nSelalu Berpikir logis\nBerkepala dingin\nOrangnya sederhana\nMemiliki sifat praktis dan kritis terhadap sesuatu";
            }
            else if (zodiak == "Scorpio")
            {
                sifat = "Merupakan pribadi yang gigih\nSangat pendendam\nLebih cenderung pendiam\nPanjang akal\nTekun dalam bekerja";
            }






            rcbview.Clear();
   
            rcbview.AppendText("Nama Lengkap : " + txtnama.Text + "\n");
            rcbview.AppendText("Tempat, Tanggal Lahir : " + txttempat.Text + ", " + dtptanggal.Text + "\n");
            rcbview.AppendText("Jenis Kelamin:" + JenisKelamin + "\n");
            rcbview.AppendText("Zodiak:" + zodiak + "\n");
            rcbview.AppendText("Memiliki Sifat:\n" + sifat + "\n");

        }

        private void rbperempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbperempuan.Checked)
            {
                JenisKelamin = rbperempuan.Text;

            }
        }

        private void rcbview_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttempat_TextChanged(object sender, EventArgs e)
        {

        }


   

        private void btnclear_Click(object sender, EventArgs e)
        {
            rcbview.Clear();
            txtnama.Clear();
            txttempat.Clear();
           
        }

        private void dtptanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
