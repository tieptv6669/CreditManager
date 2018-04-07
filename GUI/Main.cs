using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panelSelectedButton.Top = btnCustomer.Top;
            panelSelectedButton.Height = btnCustomer.Height;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelSelectedButton.Top = btnCustomer.Top;
            panelSelectedButton.Height = btnCustomer.Height;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            panelSelectedButton.Top = btnCash.Top;
            panelSelectedButton.Height = btnCash.Height;
        }

        private void btnSubmitStock_Click(object sender, EventArgs e)
        {
            panelSelectedButton.Top = btnSubmitStock.Top;
            panelSelectedButton.Height = btnSubmitStock.Height;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            panelSelectedButton.Top = btnStock.Top;
            panelSelectedButton.Height = btnStock.Height;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            panelSelectedButton.Top = btnExchange.Top;
            panelSelectedButton.Height = btnExchange.Height;
        }
    }
}
