using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SignUpAndSignIn
{
    public partial class Books : Form
    {
        private SqlConnection conn;
        public Books()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\PROGRAMMINGS\\C#programs\\repos\\SignUpAndSignInupdate\\SignUpAndSignIn\\SignUpAndSignIn\\LoginDB.mdf;Integrated Security=True");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            conn.Open();

            SqlCommand com = new SqlCommand("Select * from books order by accesion_number asc", conn);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            conn.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand com = new SqlCommand("Select * from books where title like'%" + txtsearch.Text + "%'", conn);
            com.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            grid1.DataSource = tab;

            conn.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand com = new SqlCommand("Insert into books values ('" + txtno.Text + "', '" + txttitle.Text + "', '" + txtauthor.Text + "')", conn);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            loadDatagrid();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            conn.Open();
            int no;
            no = int.Parse(txtno.Text);

            SqlCommand com = new SqlCommand("Update books SET title= '" + txttitle.Text + "', author='" + txtauthor.Text + "' where accesion_number= '" + no + "'", conn);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            loadDatagrid();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            conn.Open();
            int num = int.Parse(txtno.Text);
            //string num = txtno.Text;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("Delete from books where accesion_number= '" + num + "'", conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Successfully DELETED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
            loadDatagrid();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = grid1.Rows[e.RowIndex].Cells["accesion_number"].Value.ToString();
            txttitle.Text = grid1.Rows[e.RowIndex].Cells["title"].Value.ToString();
            txtauthor.Text = grid1.Rows[e.RowIndex].Cells["author"].Value.ToString();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frmmenu = new Menu();
            frmmenu.ShowDialog();
        }
    }
}
