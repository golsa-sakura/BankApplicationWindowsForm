using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace BankingApplication
{
    public partial class UpdationForm : Form
    {

        Banking_db_newEntities dbe;

        BindingList<userAccount> bi;




        public UpdationForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Banking_db_newEntities();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Banking_db_newEntities();
            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);

            }
            dataGridView1.DataSource = bi;
        }

        // by clicking a cell on datagrid view
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new Banking_db_newEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            // account number is assigned
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();

            // Get the data from the database table
            acctxt.Text = item.Account_No.ToString();

            nametxt.Text = item.Name;
            phonetxt.Text = item.PhoneNo;
            addresstxt.Text = item.Address;

            disttxt.Text = item.District;
            statetxt.Text = item.State;



        }



        private void button4_Click(object sender, EventArgs e)
        {
            // delete data from datagrid

            bi.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            // bi.RemoveAt(dataGridView1.SelectedRows[0].Index);

            dbe = new Banking_db_newEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbe = new Banking_db_newEntities();
            decimal accountno = Convert.ToDecimal(acctxt.Text);
            userAccount useraccount = dbe.userAccounts.First(s => s.Account_No.Equals(accountno));
            useraccount.Account_No = Convert.ToDecimal(acctxt.Text);
            useraccount.Name = nametxt.Text;
            //useraccount.Date = dateTimePicker1.Value.ToString();

            useraccount.PhoneNo = phonetxt.Text;

            useraccount.Address = addresstxt.Text;
            useraccount.District = disttxt.Text;
            useraccount.State = statetxt.Text;

            dbe.SaveChanges();
            MessageBox.Show("UPDATED NOW!");


        }

    }
}
