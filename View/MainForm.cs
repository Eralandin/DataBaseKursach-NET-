using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseKursach__NET_.View
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.FormClosing += ExitBtn_Click;
            openChildForm(new HomePage());
        }
        private void ExitBtn_Click(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void openChildForm(Form childForm)
        {
            SuspendLayout();
            if (activeForm != null && (childForm.GetType() == activeForm.GetType()))
                return;
            else if (activeForm != null)
                activeForm.Dispose();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            ResumeLayout(true);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            BottomLabel.Text = "Главная страница";
            HomePage homePage = new HomePage();
            openChildForm(homePage);
        }

        private void GroupsBtn_Click(object sender, EventArgs e)
        {
            BottomLabel.Text = "Группы товаров";
            ProductGroupsPage productGroupsPage = new ProductGroupsPage();
            openChildForm(productGroupsPage);
        }

        private void ManufacturersBtn_Click(object sender, EventArgs e)
        {
            BottomLabel.Text = "Производители";
            ManufacturersPage manufacturersPage = new ManufacturersPage();
            openChildForm(manufacturersPage);
        }

        private void AccountingUnitsBtn_Click(object sender, EventArgs e)
        {
            BottomLabel.Text = "Учётные единицы";
            AccountingUnitsPage accountingUnitsPage = new AccountingUnitsPage();
            openChildForm(accountingUnitsPage);
        }
    }
}
