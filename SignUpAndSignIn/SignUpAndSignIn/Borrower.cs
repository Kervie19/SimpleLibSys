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
    public partial class Borrower : Form
    {
        private SqlConnection conn;
        public Borrower()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\PROGRAMMINGS\\C#programs\\repos\\SignUpAndSignInupdate\\SignUpAndSignIn\\SignUpAndSignIn\\LoginDB.mdf;Integrated Security=True");
        }

        private void Borrower_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            conn.Open();

            SqlCommand com = new SqlCommand("Select * from borrowers order by idnumber asc", conn);
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

            SqlCommand com = new SqlCommand("Select * from borrowers where firstname like'%" + txtsearch.Text + "%'", conn);
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

            SqlCommand com = new SqlCommand("Insert into borrowers values ('" + txtIdnum.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtyearlevel.Text + "', '" + txtcourse.Text + "' , '" + txtcontactno.Text + "', '" + txtaddress.Text + "')", conn);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            loadDatagrid();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            conn.Open();
            int no;
            no = int.Parse(txtIdnum.Text);

            SqlCommand com = new SqlCommand("Update borrowers SET firstname= '" + txtfirstname.Text + "', lastname='" + txtlastname.Text + "',yearlevel='" + txtyearlevel.Text +"',course='" + txtcourse.Text + "',contactno='" + txtcontactno.Text + "',address='" + txtaddress.Text + "' where idnumber= '" + no + "'", conn);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            loadDatagrid();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            conn.Open();
            int num = int.Parse(txtIdnum.Text);
            //string num = txtno.Text;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("Delete from borrowers where idnumber= '" + num + "'", conn);
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
            txtIdnum.Text = grid1.Rows[e.RowIndex].Cells["idnumber"].Value.ToString();
            txtfirstname.Text = grid1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
            txtlastname.Text = grid1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
            txtyearlevel.Text = grid1.Rows[e.RowIndex].Cells["yearlevel"].Value.ToString();
            txtcourse.Text = grid1.Rows[e.RowIndex].Cells["course"].Value.ToString();
            txtcontactno.Text = grid1.Rows[e.RowIndex].Cells["contactno"].Value.ToString();
            txtaddress.Text = grid1.Rows[e.RowIndex].Cells["address"].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frmmenu = new Menu();
            frmmenu.ShowDialog();
         
        }
    }
}
