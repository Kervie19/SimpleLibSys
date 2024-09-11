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

namespace SignUpAndSignIn
{
    public partial class Borrow : Form
    {
        private SqlConnection conn;

        public Borrow()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\PROGRAMMINGS\\C#programs\\repos\\SignUpAndSignInupdate\\SignUpAndSignIn\\SignUpAndSignIn\\LoginDB.mdf;Integrated Security=True");
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Get the selected book information from the Books form
            int accesionNumber = Convert.ToInt32(txtAccessionNumber.Text);
            string title = txtTitle.Text;

            // Check if the borrower information is valid
            if (txtBorrowerName.Text.Trim() == "" || txtBorrowerAddress.Text.Trim() == "" || txtBorrowerContactNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the borrower's name, address, and contact number.", "Invalid Borrower Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the borrowing transaction to the database
            conn.Open();

            SqlCommand com = new SqlCommand("Insert into borrows (accesion_number, title, borrower_name, borrower_address, borrower_contact_number) values (@accesion_number, @title, @borrower_name, @borrower_address, @borrower_contact_number)", conn);
            com.Parameters.AddWithValue("@accesion_number", accesionNumber);
            com.Parameters.AddWithValue("@title", title);
            com.Parameters.AddWithValue("@borrower_name", txtBorrowerName.Text);
            com.Parameters.AddWithValue("@borrower_address", txtBorrowerAddress.Text);
            com.Parameters.AddWithValue("@borrower_contact_number", txtBorrowerContactNumber.Text);

            com.ExecuteNonQuery();

            MessageBox.Show("Successfully BORROWED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();

            this.Close();
        }
    }
}