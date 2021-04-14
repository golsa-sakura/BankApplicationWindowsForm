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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
        }

        private void loaddate()
        {
           
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }


        // this button is connected to update button 
        private void detailsbutton_Click(object sender, EventArgs e)
        {
            Banking_db_newEntities context = new Banking_db_newEntities();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DepAmount = Convert.ToDecimal(amounttxt.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where 
                u.Account_No == b select u).FirstOrDefault();


            item.balance = item.balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("The Amount Deposited Successfully!");

        }

        // this button is connected to get details button
        private void button1_Click(object sender, EventArgs e)
        {
            Banking_db_newEntities context = new Banking_db_newEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();


            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.balance);

        }
    }
}
