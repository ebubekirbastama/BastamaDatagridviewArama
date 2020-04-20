using System;
using System.Data;
using System.Windows.Forms;

namespace BastamaDatagridviewArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table;
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("TC", typeof(string));
            table.Columns.Add("Ad", typeof(string));
            table.Columns.Add("Soyad", typeof(string));
            table.Columns.Add("Adres", typeof(string));

            table.Rows.Add("453453453453", "Ali", "Serçe", "Ataşehir");
            table.Rows.Add("5432453453453", "Veli", "Şahin", "Fatih");
            table.Rows.Add("453453453453", "Veli", "Şahin", "Fatih");
            table.Rows.Add("453453453453", "Ayşe", "Kartal", "Kadıköy");
            table.Rows.Add("45345345354343", "Burak", "Doğan", "Eyüp");
            table.Rows.Add("453453453453453", "Burak", "Doğan", "Eyüp");
            table.Rows.Add("453453453453453", "Burak", "Doğan", "Eyüp");

            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "TC like'" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
