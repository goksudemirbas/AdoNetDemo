using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-EL89P9EQ;Integrated Security=True; initial catalog=ETrade");
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsLoad();
        }

        private void ProductsLoad()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.add(new Product
            {
                Name = textBox1.Text,
                UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text)

            });
            ProductsLoad();
            MessageBox.Show("Added!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product{ 
            
            Id = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value),
            Name = textBox6.Text,
            UnitPrice =Convert.ToDecimal( textBox5.Text),
            StockAmount= Convert.ToInt32(textBox4.Text)



            };
            _productDal.update(product);
            ProductsLoad();
            MessageBox.Show("Updated!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _productDal.delete(Id);
            ProductsLoad();
            MessageBox.Show("Deleted!");

        }
    }
}
