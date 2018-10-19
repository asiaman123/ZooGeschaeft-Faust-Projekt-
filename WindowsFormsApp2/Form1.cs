using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static List<object> tierList = new List<object>();

        public Form1()
        {
            InitializeComponent();
           
            Vogel vogel1 = new Vogel(50, 0.25, 0.3, true, 50);
            tierList.Add(vogel1);
            Vogel vogel2 = new Vogel(25, 0.25, 0.3, true, 25);
            tierList.Add(vogel2);
            Fisch fisch1 = new Fisch(5, 0.01, 0.05, 2);
            tierList.Add(fisch1);
            Fisch fisch2 = new Fisch(2.5, 0.02, 0.01, 4);
            tierList.Add(fisch2);
            Reptil reptil1 = new Reptil(100, 2, 0.5, true);
            tierList.Add(reptil1);
            Reptil reptil2 = new Reptil(75, 1, 1, false);
            tierList.Add(reptil2);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String groesse = "";
            String preis = "";
            String gewicht = "";
            String zeugs = "";
            String zeug = "";
            if (tierListe.SelectedItem is Fisch)
            {
                label2.Text = "Fisch";
                Fisch fisch = tierListe.SelectedItem as Fisch;
                groesse = fisch.groesse.ToString();
                label8.Text = groesse;
                preis = fisch.preis.ToString();
                label6.Text = preis;
                gewicht = fisch.gewicht.ToString();
                label10.Text = gewicht;
                zeugs = fisch.flosse.ToString();
                label12.Text = zeugs;
                label11.Text = "Flossen";
            }
            else if (tierListe.SelectedItem is Reptil)
            {
                label2.Text = "Reptil";
                Reptil reptil = tierListe.SelectedItem as Reptil;
                groesse = reptil.groesse.ToString();
                label8.Text = groesse;
                preis = reptil.preis.ToString();
                label6.Text = preis;
                gewicht = reptil.gewicht.ToString();
                label10.Text = gewicht;
                zeugs = reptil.giftig.ToString();
                label12.Text = zeugs;
                label11.Text = "Giftig";
            }
            else if (tierListe.SelectedItem is Vogel)
            {
                label2.Text = "Vogel";
                Vogel vogel = tierListe.SelectedItem as Vogel;
                groesse = vogel.groesse.ToString();
                label8.Text = groesse;
                preis = vogel.preis.ToString();
                label6.Text = preis;
                gewicht = vogel.gewicht.ToString();
                label10.Text = gewicht;
                zeugs = vogel.flug.ToString();
                label12.Text = zeugs;
                label11.Text = "Flugfähig";
                if (vogel.flug == true)
                {
                    zeug = "Ja";
                }
                else
                {
                    zeug = "Nein";
                }
                label13.Text = "Flugreichweite";
                label14.Text = zeug;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        internal void AddToListReptile(double preis,double gewicht, double groesse, Boolean giftig)
        {
            Reptil rep = new Reptil(preis, gewicht, groesse, giftig);
            tierList.Add(rep);
            tierListe.DataSource = null;
            tierListe.DataSource = tierList;

        }

        internal void AddToListVogel(double preis, double gewicht, double groesse, Boolean flug,double reichweite)
        {
            Vogel rep = new Vogel(preis, gewicht, groesse, flug, reichweite);
            tierList.Add(rep);
            tierListe.DataSource = null;
            tierListe.DataSource = tierList;

        }
        internal void AddToListFisch(double preis, double gewicht, double groesse, int flossen)
        {
            Fisch rep = new Fisch(preis, gewicht, groesse, flossen);
            tierList.Add(rep);
            tierListe.DataSource = null;
            tierListe.DataSource = tierList;

        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            tierListe.DataSource = tierList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tierListe.SelectedItem is Fisch || tierListe.SelectedItem is Vogel)
            {
                int index = tierListe.SelectedIndex;
                tierList.RemoveAt(index);
                tierListe.DataSource = null;
                tierListe.DataSource = tierList;

            }
            else
            {
                bool check = CheckboxDialog.ShowDialog("Ueber 18?","Straffrei?","Test");
                if (check)
                {
                    int index = tierListe.SelectedIndex;
                    tierList.RemoveAt(index);
                    tierListe.DataSource = null;
                    tierListe.DataSource = tierList;


                }
                else
                {
                    MessageBox.Show("Kauf nicht möglich!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verkaufen verk = new Verkaufen();
            verk.ShowDialog();
        }
    }
}
