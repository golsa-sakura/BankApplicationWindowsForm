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

namespace BankingApplication
{
    public partial class newAccount : Form
    {

       
        decimal no;

        // create a instance of database

        Banking_db_newEntities BSE;
       
        // making a constructor
        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            Loadstate();
        }

        private void Loadstate()
        {
           
            comboBox1.Items.Add("New York");
            comboBox1.Items.Add("New Jeresy");
            comboBox1.Items.Add("New Orleans");
            comboBox1.Items.Add("Texas");
        }

        private void loadaccount()
        {
            BSE = new Banking_db_newEntities();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);


           
        }

        private void loaddate()
        {
            
            datelbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            



            BSE = new Banking_db_newEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addtxt.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("The New Account Has Been Created Successfully!");

            

        }
    }
}
