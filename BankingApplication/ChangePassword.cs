using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking_db_newEntities dbe = new Banking_db_newEntities();
            if (oldpasstxt.Text != string.Empty || newpasstxt.Text != string.Empty || retypepasstxt.Text != string.Empty)
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usertxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(oldpasstxt.Text))
                    {
                        user1.Password = newpasstxt.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Password changed successfully!");


                    }
                    else
                    {
                        MessageBox.Show("password incorrect");
                    }
                }
            }
        }
    }
}
