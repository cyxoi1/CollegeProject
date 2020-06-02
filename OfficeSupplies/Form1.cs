using OfficeSupplies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//==================
namespace OfficeSupplies
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.UserName = "admin";
            employee.Password = "1234";
            if (employee.Login(userNameText.Text, passwordText.Text))
            {
                this.Hide();
                Menu mainMenu = new Menu();
                mainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("You enter a wrong username and password, please try again!!!");
            }
        }
    }
}
