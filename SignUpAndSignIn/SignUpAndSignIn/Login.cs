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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\PROGRAMMINGS\\C#programs\\repos\\SignUpAndSignInupdate\\SignUpAndSignIn\\SignUpAndSignIn\\LoginDB.mdf;Integrated Security=True");

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
                string Password = "";
                bool IsExist = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from users where username='" + txtusername.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Password = sdr.GetString(2);  //get the user password from db if the user name is exist in that.  
                    IsExist = true;
                }
                con.Close();
                if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
                {
                    if (Cryptography.Decrypt(Password).Equals(txtpassword.Text))
                    {
                        this.Hide();
                        MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu frmmenu = new Menu();
                        frmmenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else  //showing the error message if user credential is wrong  
                {
                    MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }
    }
}

