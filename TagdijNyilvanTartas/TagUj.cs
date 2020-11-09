using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagdijNyilvanTartas
{
    public partial class TagUj : Form
    {
        public TagUj()
        {
            InitializeComponent();
        }

        private void TagUj_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textbox_nev.Text.Trim();
            int szulEv = (int) numericUpDown_szulev.Value;
            string irSzamString = textBox_iranyitoszam.Text.Trim();
            int irSzam;
            string orszag = comboBox_orszag.Text.Trim();

            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Kötelező mező!", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_nev.Focus();
                return;
            }

            if (string.IsNullOrEmpty(irSzamString))
            {
                MessageBox.Show("Kötelező mező!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_iranyitoszam.Focus();
                return;
            }

            if (!int.TryParse(irSzamString, out irSzam))
            {
                MessageBox.Show("Számot kell megadni!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_iranyitoszam.Focus();
                return;
            }

            if (string.IsNullOrEmpty(orszag))
            {
                MessageBox.Show("Kötelező mező!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_orszag.Focus();
                return;
            }

            Program.mySqlCommand.CommandText = "INSERT INTO ugyfel (nev, szulev, irszam, orsz) VALUES ('" + nev + "'," + szulEv + "," + irSzam + ",'" + orszag + "')";
            Program.mySqlCommand.ExecuteNonQuery();

            MessageBox.Show("Sikeres mentés!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textbox_nev.Text = "";
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;
            textBox_iranyitoszam.Text = "";
            comboBox_orszag.Text = "";
        }
    }
}
