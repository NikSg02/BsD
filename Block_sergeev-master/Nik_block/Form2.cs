using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //для работы с файлами БД

namespace Tinker_quest
{
    
    public partial class Form2 : Form
    {
        string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Block_sergeev-master\Block_sergeev-master\Nik_block\MyDataBase\MyDataBase.mdf;Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
            //
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillContract();
            FillDannySwD();
            FillSiruy();
            FillSupplier();
        }
        private void FillSiruy()
        {
            string SqlText = "SELECT * FROM [Siruy]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Siruy]");
            dataGridView1.DataSource = ds.Tables["[Siruy]"].DefaultView;
        }
      
        
        private void FillSupplier()
        {
            string SqlText = "SELECT * FROM [Supplier]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Supplier]");
            dataGridView2.DataSource = ds.Tables["[Supplier]"].DefaultView;
        }
        private void FillDannySwD()
        {
            string SqlText = "SELECT * FROM [DannySwD]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[DannySwD]");
            dataGridView4.DataSource = ds.Tables["[DannySwD]"].DefaultView;
        }
        private void FillContract()
        {
            string SqlText = "SELECT * FROM [Contract]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Contract]");
            dataGridView3.DataSource = ds.Tables["[Contract]"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
