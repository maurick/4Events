using _4Events.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4Events.Database;
using _4Events.Model;

namespace _4Events
{
    public partial class LoginForm : Form
    {
        AccountRepository accountRepo = new AccountRepository(new AccountContext());
        List<Account> accountList;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accountList = accountRepo.GetAll();

            foreach (var item in accountList)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
