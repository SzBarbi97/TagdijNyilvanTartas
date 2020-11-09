using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TagdijNyilvanTartas
{
    public partial class TagModositas : Form
    {
        public TagModositas()
        {
            InitializeComponent();
        }

        static int azon = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textbox_nev.Text.Trim();
            int szulEv = (int)numericUpDown_szulev.Value;
            string irSzamString = textBox_iranyitoszam.Text.Trim();
            int irSzam;
            string orszag = comboBox_orszag.Text.Trim();

            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Kötelező mező!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            Program.mySqlCommand.CommandText = "UPDATE ugyfel SET `nev`= '" + nev + "',`szulev`= " + szulEv + ",`irszam`= " + irSzam + ",`orsz`= '" + orszag + "' WHERE `azon`=" + azon;
            Program.mySqlCommand.ExecuteNonQuery();

            MessageBox.Show("Sikeres mentés!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textbox_nev.Text = "";
            numericUpDown_szulev.Value = numericUpDown_szulev.Minimum;
            textBox_iranyitoszam.Text = "";
            comboBox_orszag.Text = "";

            dataGridView_ugyfel.ClearSelection();
            dataGridView_ugyfel.Rows.Clear();
            beolvas();
        }

        private void TagModositas_Load(object sender, EventArgs e)
        {
            dataGridView_ugyfel.ColumnCount = 5;
            dataGridView_ugyfel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ugyfel.Columns[0].Name = "azon";
            dataGridView_ugyfel.Columns[0].HeaderText = "azonosító";
            dataGridView_ugyfel.Columns[1].Name = "nev";
            dataGridView_ugyfel.Columns[1].HeaderText = "Név";
            dataGridView_ugyfel.Columns[2].Name = "szulev";
            dataGridView_ugyfel.Columns[2].HeaderText = "Születési év";
            dataGridView_ugyfel.Columns[3].Name = "irszam";
            dataGridView_ugyfel.Columns[3].HeaderText = "Irányító szám";
            dataGridView_ugyfel.Columns[4].Name = "orsz";
            dataGridView_ugyfel.Columns[4].HeaderText = "Ország";

            beolvas();
        }

        private void beolvas()
        {
            try
            {
                Program.mySqlCommand.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel`";
                using (MySqlDataReader dr = Program.mySqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_ugyfel.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_ugyfel.Rows[uj_sor_indexe];
                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["szulev"].Value = dr.GetInt32("szulev");
                        uj_sor.Cells["irszam"].Value = dr.GetInt32("irszam");
                        uj_sor.Cells["orsz"].Value = dr.GetString("orsz");


                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
        }

        private void dataGridView_ugyfel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow sor = dataGridView_ugyfel.Rows[e.RowIndex];
            textbox_nev.Text = sor.Cells["nev"].Value.ToString();
            numericUpDown_szulev.Value = Convert.ToInt32(sor.Cells["szulev"].Value.ToString());
            textBox_iranyitoszam.Text = sor.Cells["irszam"].Value.ToString();
            comboBox_orszag.Text = sor.Cells["orsz"].Value.ToString();

            azon = (int) sor.Cells["azon"].Value;
        }
    }
}
