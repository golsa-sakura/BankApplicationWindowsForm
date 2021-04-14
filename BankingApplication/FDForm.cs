﻿using System;
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
    public partial class FDForm : Form
    {
        public FDForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Banking_db_newEntities dbe = new Banking_db_newEntities();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(accnotxt.Text);
            fdform.Mode = comboBox1.SelectedItem.ToString();
            fdform.Dollars = dollarstxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.Interest_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("dd/MM/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(dollarstxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text)) / 
                                        (100 * 12 * 30)) + (Convert.ToDecimal(dollarstxt.Text));

            dbe.FDs.Add(fdform);
            Decimal amount = Convert.ToDecimal(dollarstxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdamount = totalamount - amount;
            accounts.balance = fdamount;
            

            dbe.SaveChanges();
            MessageBox.Show("FD Started Now");



        }
    }
}
