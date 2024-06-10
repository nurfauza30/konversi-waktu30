using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konversi_waktu30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btHasil_Click(object sender, EventArgs e)
        {
            double hasil = 0;
            int menit, second, milisecond;

            if (cbWaktu.SelectedItem == "jam" && cbWaktu1.SelectedText == "menit") ;
            {
                hasil = int.Parse(txWaktu.Text)*60;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "jam" && cbWaktu1.SelectedText == "second") ;
            {
                hasil = int.Parse(txWaktu.Text) *3600;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "jam" && cbWaktu1.SelectedText == "milisecond") ;
            {
                hasil = int.Parse(txWaktu.Text) * 3600000;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "menit" && cbWaktu1.SelectedText == "second") ;
            {
                hasil = int.Parse(txWaktu.Text) *60;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "menit" && cbWaktu1.SelectedText == "milisecond") ;
            {
                hasil = int.Parse(txWaktu.Text) * 60000;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "menit" && cbWaktu1.SelectedText == "jam") ;
            {
                hasil = int.Parse(txWaktu.Text) * 0.0166667;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "second" && cbWaktu2.SelectedText == "menit") ;
            {
                hasil = int.Parse(txWaktu.Text) * 0.0166667;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "second" && cbWaktu1.SelectedText == "milisecond") ;
            {
                hasil = int.Parse(txWaktu.Text) * 1000;
                txhasil.Text = hasil.ToString();
            }

            if (cbWaktu.SelectedItem == "second" && cbWaktu1.SelectedText == "jam") ;
            {
                hasil = int.Parse(txWaktu.Text) * 0.000277778;
                txhasil.Text = hasil.ToString();
            }

        }

        private void cbWaktu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
