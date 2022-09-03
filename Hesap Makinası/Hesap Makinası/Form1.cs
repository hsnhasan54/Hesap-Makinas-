using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {
        bool optdurum = true;
        double sonuc = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void esittir(object sender, EventArgs e)
        {
            label2.Text = "";
            optdurum = true;
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;

            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = "";

        }
        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if (optdurum)
            {
                textBox1.Text = "0";
            }

            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ",";
            }
            optdurum = false;   
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tusabasma(object sender, EventArgs e)
        { if (textBox1.Text == "0")
                textBox1.Clear();
            Button but = (Button)sender;
            textBox1.Text += but.Text;
            optdurum = false;

        }

        private void optbasma(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label2.Text = btn.Text;
            string yenopt = btn.Text;
            label2.Text += label2 + " " + textBox1 + " " + yenopt;
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;

            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = yenopt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
