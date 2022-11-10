using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_11_2022_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowGame_Click(object sender, EventArgs e)
        {
            Igra prva = new Igra();
            prva.ImeIgre = "šah";
            prva.BrojIgraca = 2;

            IgraNaVrijeme druga = new IgraNaVrijeme();
            druga.ImeIgre = "nogomet";
            druga.BrojIgraca = 22;
            druga.TrajanjeIgre = 90;

            lblReturnGame.Text += prva.ToString() + "\n";
            lblReturnGame.Text +=druga.ToString();

        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            Traka traka1 = new Traka() ;
            traka1.Sirina = 2.23;
            traka1.Duljina = 5;

            FilmskaTraka traka2 = new FilmskaTraka() ;
            traka2.Sirina = 3.5;
            traka2.Duljina = 3000;
            traka2.Trajanje = 11;

            LjepljivaTraka traka3 = new LjepljivaTraka() ;
            traka3.Sirina = 1.75;
            traka3.Duljina = 10;
            traka3.Ljepljivost = 7;

            lblReturn2.Text += traka1.ToString() + "\n";
            lblReturn2.Text += traka2.ToString() + "\n";
            lblReturn2.Text += traka3.ToString() + "\n";
            lblReturn2.Text += "\n" + "Ispis nakon postavljanja svojstva \"Ljepljivost\" na nedozvoljenu vrijednost:" + "\n";

            traka3.Ljepljivost = 15;

            lblReturn2.Text += "\n" + traka3.ToString() + "\n";
        }
    }
}
