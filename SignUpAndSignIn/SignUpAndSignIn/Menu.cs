using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpAndSignIn
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrow = new Borrower();
            borrow.ShowDialog();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.ShowDialog();
        }
    }
}
