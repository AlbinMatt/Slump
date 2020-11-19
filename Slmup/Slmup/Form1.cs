using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slmup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = slump.Next(0, 101);
        }
        int antal = 0;
        Random slump = new Random();
        int random;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int tal = int.Parse(textBox1.Text);
            label2.Text = ("");
            label4.Text = ("");
            label5.Text = ("");

            antal++;
            if (tal < random)
            {
                label2.Text = ("Din gissning var för låg: ");
                label4.Text = ("Försök igen: ");
                label5.Text = ("Du har gissat: " + antal);
            }
            else if (tal > random)
            {
                label2.Text = ("Din gissning var för hög: ");
                label4.Text = ("Försök igen: ");
                label5.Text = ("Du har gissat: " + antal);
            }
            else
            {
                label2.Text = ("Din gissning var Rätt: ");
                label5.Text = ("Du har gissat: " + antal);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
