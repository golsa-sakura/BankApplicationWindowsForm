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
    public partial class DebitForm : Form
    {
        public DebitForm()
        {
            InitializeComponent();
            loadmode();
            loaddate();

        }

        private void loaddate()
        {
            
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void loadmode()
        {
            
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
        }

        private void DebitForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            Banking_db_newEntities dbe = new Banking_db_newEntities();
            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            nametxt.Text = item.Name;
            oldbalanacetxt.Text = Convert.ToString(item.balance);



        }

        private void button1_Click(object sender, EventArgs e)
        {


            Banking_db_newEntities dbe = new Banking_db_newEntities();
            newAccount nacc = new newAccount();
            debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(accnotxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbalanacetxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dbe.debits.Add(dp);
            dbe.SaveChanges();

            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            item.balance = item.balance - Convert.ToDecimal(amounttxt.Text);
            dbe.SaveChanges();
            MessageBox.Show(" The Amount Has Been Withdrwned Successfully! ");

        }
    }
}
