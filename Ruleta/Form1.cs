using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pocetkliknuti = 0;
        int vyherni, vyherni2, klik;
        private void button1_Click(object sender, EventArgs e)
        {
            pocetkliknuti++;
            int nahodne = 0;

            if (pocetkliknuti % 2 == 0)
            {
                Random cislo = new Random();
                nahodne = cislo.Next(1, 17);
                label18.Text = "Výherní číslo je  " + nahodne;
                if(nahodne % 2 == 0)
                {
                    label19.Text = "Výherní barva je červená ";
                }
                else
                {
                    label19.Text = "Výherní barva je zelená ";
                }
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                numericUpDown1.Visible = false;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                if (nahodne == 1)
                {
                    label2.ForeColor = Color.Yellow;
                }
                else
                {
                    label2.ForeColor = Color.Black;
                }
                if (nahodne == 2)
                {
                    label3.ForeColor = Color.Yellow;
                }
                else
                {
                    label3.ForeColor = Color.Black;
                }
                if (nahodne == 3)
                {
                    label4.ForeColor = Color.Yellow;
                }
                else
                {
                    label4.ForeColor = Color.Black;
                }
                if (nahodne == 4)
                {
                    label5.ForeColor = Color.Yellow;
                }
                else
                {
                    label5.ForeColor = Color.Black;
                }
                if (nahodne == 5)
                {
                    label6.ForeColor = Color.Yellow;
                }
                else
                {
                    label6.ForeColor = Color.Black;
                }
                if (nahodne == 6)
                {
                    label7.ForeColor = Color.Yellow;
                }
                else
                {
                    label7.ForeColor = Color.Black;
                }
                if (nahodne == 7)
                {
                    label8.ForeColor = Color.Yellow;
                }
                else
                {
                    label8.ForeColor = Color.Black;
                }
                if (nahodne == 8)
                {
                    label9.ForeColor = Color.Yellow;
                }
                else
                {
                    label9.ForeColor = Color.Black;
                }
                if (nahodne == 9)
                {
                    label10.ForeColor = Color.Yellow;
                }
                else
                {
                    label10.ForeColor = Color.Black;
                }
                if (nahodne == 10)
                {
                    label11.ForeColor = Color.Yellow;
                }
                else
                {
                    label11.ForeColor = Color.Black;
                }
                if (nahodne == 11)
                {
                    label12.ForeColor = Color.Yellow;
                }
                else
                {
                    label12.ForeColor = Color.Black;
                }
                if (nahodne == 12)
                {
                    label13.ForeColor = Color.Yellow;
                }
                else
                {
                    label13.ForeColor = Color.Black;
                }
                if (nahodne == 13)
                {
                    label14.ForeColor = Color.Yellow;
                }
                else
                {
                    label14.ForeColor = Color.Black;
                }
                if (nahodne == 14)
                {
                    label15.ForeColor = Color.Yellow;
                }
                else
                {
                    label15.ForeColor = Color.Black;
                }
                if (nahodne == 15)
                {
                    label16.ForeColor = Color.Yellow;
                }
                else
                {
                    label16.ForeColor = Color.Black;
                }
                if (nahodne == 16)
                {
                    label17.ForeColor = Color.Yellow;
                }
                else
                {
                    label17.ForeColor = Color.Black;
                }
                if (klik == 1)
                {
                    if (vyherni == 1)
                    {
                        if (nahodne % 2 == 0)
                        {
                            MessageBox.Show("Vyhrál jsi!", "Vítězství", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nevyhrál jsi!", "Prohra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (vyherni == 2)
                    {
                        if (nahodne % 2 != 0)
                        {
                            MessageBox.Show("Vyhrál jsi!", "Vítězství", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nevyhrál jsi!", "Prohra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (klik == 2)
                {
                    if (vyherni2 == nahodne)
                    {
                        MessageBox.Show("Vyhrál jsi!", "Vítězství", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nevyhrál jsi!", "Prohra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                label18.Text = "Ruleta se točí...";
                label19.Text = "";
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zvol si, jestli chceš sázet na barvu, nebo na číslo. Stiskni 'Start/Stop' pro zapnutí rulety a poté to stejné tlačítko pro její vypnutí.", "Nápověda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            klik = 1;
            button2.Enabled = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            if(radioButton1.Checked || radioButton2.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if(radioButton1.Checked)
            {
                vyherni = 1;
            }
            else
            {
                vyherni = 2;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            klik = 2;
            button1.Enabled = true;
            button3.Enabled = false;
            numericUpDown1.Visible = true;
            vyherni2 = (int)numericUpDown1.Value;
        }
    }
}
