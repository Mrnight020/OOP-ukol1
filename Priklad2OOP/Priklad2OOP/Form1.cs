using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad2OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clovek clovicek1 = new Clovek(textBox1.Text, maskedTextBox1.Text);
                Clovek clovicek2 = new Clovek(textBox2.Text, maskedTextBox2.Text);
                MessageBox.Show("Jmeno 1. cloveka: " + clovicek1.VypisJmeno() + "\n" +
                                "Jmeno 2. cloveka: " + clovicek2.VypisJmeno());

                clovicek2.NastavJmeno("Pepa");
                textBox2.Text = "Pepa";

                MessageBox.Show("Jméno : " + clovicek1.VypisJmeno() + "\n\n" +
                                "Vek :" + ((int)clovicek1.Vek()) + "\n\n" +
                                String.Format("Je plnolety ? : {0}", clovicek1.Plnolety() ? "Ano" : "Ne") + "\n\n" +
                                clovicek1.ToString(), "Clovek1");

                MessageBox.Show("Jméno : " + clovicek2.VypisJmeno() + "\n\n" +
                                "Vek Pepi: " + ((int)clovicek2.Vek()) + "\n\n" +
                                String.Format("Je plnolety ? : {0}", clovicek2.Plnolety() ? "Ano" : "Ne") + "\n\n" +
                                clovicek2.ToString(), "Clovek2");

                MessageBox.Show(clovicek1.Starsi(clovicek1, clovicek2));
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
