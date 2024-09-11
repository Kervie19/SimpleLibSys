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
    public partial class frmRegister : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public frmRegister()
        {
            InitializeComponent();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\PROGRAMMINGS\\C#programs\\repos\\SignUpAndSignInupdate\\SignUpAndSignIn\\SignUpAndSignIn\\LoginDB.mdf;Integrated Security=True");
            con.Open();
          
        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtConPass.Text != string.Empty || txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                if (txtPassword.Text == txtConPass.Text)
                {
                    cmd = new SqlCommand("select * from users where username='" + txtUsername.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into users values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", Cryptography.Encrypt(txtPassword.Text.ToString()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

       
    }
}
