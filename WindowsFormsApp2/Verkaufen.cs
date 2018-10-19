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
    public partial class Verkaufen : Form
    {
        double preis { get; set; }
        double gewicht { get; set; }
        double groesse { get; set; }
        int flossen { get; set; }
        Boolean giftig { get; set; }
        Boolean flug { get; set; }
        double flugreichweite { get; set; }

        public Verkaufen()
        {
            InitializeComponent();
            List<String> art = new List<String>();
            art.Add("Fisch");
            art.Add("Vogel");
            art.Add("Reptil");
            listBox1.DataSource = art;
            maskedTextBox4.Hide();
            maskedTextBox5.Hide();
            label5.Hide();
            label7.Hide();
            label3.Text = "Flossenanzahl";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Fisch"))
            {
                label3.Text = "Flossenanzahl";
                label5.Hide();
                label7.Hide();
                maskedTextBox3.Show();
                label3.Show();
                maskedTextBox4.Hide();
                maskedTextBox5.Hide();
            }
            else if (listBox1.SelectedItem.Equals("Vogel"))
            {
                label3.Text = "Flugfähig? Bitte geben Sie Ja oder Nein an.";
                label5.Text = "Flugreichweite";
                label7.Hide();
                maskedTextBox5.Hide();
                maskedTextBox3.Show();
                label3.Show();
                maskedTextBox4.Show();
                label5.Show();


            }
            else if (listBox1.SelectedItem.Equals("Reptil"))
            {
                label3.Text="Giftig? Bitte geben Sie Ja oder Nein an.";
                label5.Hide();
                label7.Hide();
                maskedTextBox3.Show();
                label3.Show();
                maskedTextBox4.Hide();
                maskedTextBox5.Hide();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Fisch"))
            {
                preis = Convert.ToDouble(textBox1.Text);
                gewicht = Convert.ToDouble(maskedTextBox1.Text);
                groesse = Convert.ToDouble(maskedTextBox2.Text);
                flossen = Convert.ToInt32(maskedTextBox3.Text);

                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).AddToListFisch(preis, gewicht, groesse, flossen);
                }

            }
            else if (listBox1.SelectedItem.Equals("Vogel"))
            {
                preis = Convert.ToDouble(textBox1.Text);
                gewicht = Convert.ToDouble(maskedTextBox1.Text);
                groesse = Convert.ToDouble(maskedTextBox2.Text);
                flugreichweite = Convert.ToDouble(maskedTextBox4.Text);


                if (maskedTextBox3.Text.Equals("Ja") || maskedTextBox3.Text.Equals("ja"))
                {
                    flug = true;
                }
                else
                {
                    flug = false;
                }
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).AddToListVogel(preis, gewicht, groesse, flug, flugreichweite);
                }
            }
            else if (listBox1.SelectedItem.Equals("Reptil"))
            {
                preis = Convert.ToDouble(textBox1.Text);
                gewicht = Convert.ToDouble(maskedTextBox1.Text);
                groesse = Convert.ToDouble(maskedTextBox2.Text);
                if (maskedTextBox3.Text.Equals("Ja") || maskedTextBox3.Text.Equals("ja"))
                {
                    giftig = true;
                }
                else
                {
                    giftig = false;
                }
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).AddToListReptile(preis,gewicht,groesse,giftig);
                }
            }

            this.Hide();

        }


    }
}
