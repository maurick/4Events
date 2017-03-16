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
using _4Events.Logic;
using _4Events.Model;
using _4Events.ViewModel;

namespace _4Events.View
{
    public partial class EventBeheerForm : Form
    {
        EventBeheerViewModel viewModel = new EventBeheerViewModel();
        AccountRepository accountRepo = new AccountRepository(new AccountContext());

        public EventBeheerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            this.Close();
            form.ShowDialog();
        }
    }
}
