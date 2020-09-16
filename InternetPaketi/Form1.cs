using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetPaketi.myclass;
using MySql.Data.MySqlClient;


namespace InternetPaketi
{
    public partial class Form1 : Form
    {



        
        CRUD crud = new CRUD();

        public Form1()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            CREATE();
            READ();

        }

        private void delatebtn_Click(object sender, EventArgs e)
        {
            DELATE();
            READ();

        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_data();
            dataGridView1.DataSource = crud.dt;
        }

        public void CREATE()
        {
            crud.ime = tfIme.Text;
            crud.prezime = tfPrezime.Text;
            crud.adresa = tfAdresa.Text;
            crud.ugovor = cbUgovor.Text;
            crud.brzina = cbBrzina.Text;
            crud.Create_data();
        }
        public void DELATE()
        {
            crud.ime = tfIme.Text;
            crud.Delate_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tfIme.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    tfPrezime.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    tfAdresa.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cbUgovor.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cbBrzina.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Dont click the Header");
            }
        }

        private void cbUgovor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
