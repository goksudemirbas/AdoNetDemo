using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _ProductDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _ProductDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ProductDal.add(new Product
            {
                Name = textBox1.Text,
                UnitPrice = Convert.ToDecimal( textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text)

            }) ;
            LoadProducts();
            MessageBox.Show("ADDED!");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            _ProductDal.update(new Product
            {

                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = textBox1.Text,
                UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text)

            });
            LoadProducts();
            MessageBox.Show("updated!");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _ProductDal.delete(new Product
            {
                Id  = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("deleted!");
        }
    }
}
