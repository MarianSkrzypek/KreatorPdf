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
using iTextSharp.pdf.Wygenerowane;
namespace Formm
{
    public partial class Form1 : Form
    {
        public string FirstName
        {
            get { return Imie.Text; }
            set { Imie.Text = value; }
        }
        public string SurName
        {
            get { return Nazwisko.Text; }
            set { Nazwisko.Text = value; }
        }
        public string fraza1
        {
            get { return Fraza1.Text; }
            set { Fraza1.Text = value; }
        }
        public string fraza2
        {
            get { return Fraza2.Text; }
            set { Fraza2.Text = value; }
        }
        public string fraza3
        {
            get { return Fraza3.Text; }
            set { Fraza3.Text = value; }
        }
        public string fraza4
        {
            get { return Fraza4.Text; }
            set { Fraza4.Text = value; }
        }
        public string fraza5
        {
            get { return Fraza5.Text; }
            set { Fraza5.Text = value; }
        }
        public string fraza6
        {
            get { return Fraza6.Text; }
            set { Fraza6.Text = value; }
        }
        public string fraza7
        {
            get { return Fraza7.Text; }
            set { Fraza7.Text = value; }
        }
        public string fraza8
        {
            get { return Fraza8.Text; }
            set { Fraza8.Text = value; }
        }
        public string fraza9
        {
            get { return Fraza9.Text; }
            set { Fraza9.Text = value; }
        }
        public string fraza10
        {
            get { return Fraza10.Text; }
            set { Fraza10.Text = value; }
        }
        public string fraza11
        {
            get { return Fraza11.Text; }
            set { Fraza11.Text = value; }
        }
        public string fraza12
        {
            get { return Fraza12.Text; }
            set { Fraza12.Text = value; }
        }
        public string fraza13
        {
            get { return Fraza13.Text; }
            set { Fraza13.Text = value; }
        }
        public string fraza14
        {
            get { return Fraza14.Text; }
            set { Fraza14.Text = value; }
        }
        public string fraza15
        {
            get { return Fraza15.Text; }
            set { Fraza15.Text = value; }
        }
        public string fraza16
        {
            get { return Fraza16.Text; }
            set { Fraza16.Text = value; }
        }
        public string fraza17
        {
            get { return Fraza17.Text; }
            set { Fraza17.Text = value; }
        }
        public string fraza18
        {
            get { return Fraza18.Text; }
            set { Fraza18.Text = value; }
        }
        public string fraza19
        {
            get { return Fraza19.Text; }
            set { Fraza19.Text = value; }
        }
        public string fraza20
        {
            get { return Fraza20.Text; }
            set { Fraza20.Text = value; }
        }
        public string fraza21
        {
            get { return Fraza21.Text; }
            set { Fraza21.Text = value; }
        }
        public string fraza22
        {
            get { return Fraza22.Text; }
            set { Fraza22.Text = value; }
        }
        public string fraza23
        {
            get { return Fraza23.Text; }
            set { Fraza23.Text = value; }
        }
        public string fraza24
        {
            get { return Fraza24.Text; }
            set { Fraza24.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
            TextWriter tw = new StreamWriter("ustawienia.txt");

            // write lines of text to the file
            tw.WriteLine(FirstName);
            tw.WriteLine(SurName);
            tw.WriteLine(fraza1);
            tw.WriteLine(fraza2);
            tw.WriteLine(fraza3);
            tw.WriteLine(fraza4);
            tw.WriteLine(fraza5);
            tw.WriteLine(fraza6);
            tw.WriteLine(fraza7);
            tw.WriteLine(fraza8);
            tw.WriteLine(fraza9);
            tw.WriteLine(fraza10);
            tw.WriteLine(fraza11);
            tw.WriteLine(fraza12);
            tw.WriteLine(fraza13);
            tw.WriteLine(fraza14);
            tw.WriteLine(fraza15);
            tw.WriteLine(fraza16);
            tw.WriteLine(fraza17);
            tw.WriteLine(fraza18);
            tw.WriteLine(fraza19);
            tw.WriteLine(fraza20);
            tw.WriteLine(fraza21);
            tw.WriteLine(fraza22);
            tw.WriteLine(fraza23);
            tw.WriteLine(fraza24);
            // close the stream     
            tw.Close();
        }

        private void Imie_Leave(object sender, EventArgs e)
        {
        }

        private void Imie_Enter(object sender, EventArgs e)
        {
        }
        //fraza1
        private void Fraza1_Leave(object sender, EventArgs e)
        {
        }

        private void Fraza1_Enter(object sender, EventArgs e)
        {
        }
        public void button1_Click(object sender, EventArgs e)
        {
            new Example1(this);
            MessageBox.Show(" Zapisany do PDF-a");
        }
        public void Imie_TextChanged(object sender, EventArgs e)
        {

        }
        private void Nazwisko_TextChanged(object sender, EventArgs e)
        {

        }
    }
}