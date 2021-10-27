using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Dashboard : MetroFramework.Controls.MetroUserControl
    {
        static Dashboard _instance;
        SaleTransaction sales;
        Expenses expenses;
        public static Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dashboard();
                return _instance;
            }
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _instance = this;
            Summary summary = new Summary();
            summary.Dock = DockStyle.Fill;
            mPanel.Controls.Add(summary);
        }

        private void mbDashboard_Click(object sender, EventArgs e)
        {
            isClicked(btnDashboard);
            if (!mPanel.Controls.ContainsKey("Summary"))
            {
                Summary summary = new Summary();
                summary.Dock = DockStyle.Fill;
                mPanel.Controls.Add(summary);
            }
            FormMain.Instance.UserControl.Add("Summary");
            mPanel.Controls["Summary"].BringToFront();
        }

        private void mbTransaction_Click(object sender, EventArgs e)
        {
            isClicked(btnSalesTransaction);
            if (!mPanel.Controls.ContainsKey("SaleTransaction"))
            {
                sales = new SaleTransaction();
                sales.Dock = DockStyle.Fill;
                mPanel.Controls.Add(sales);
            }
            mPanel.Controls["SaleTransaction"].BringToFront();
        }

        private void mbSettings_Click(object sender, EventArgs e)
        {
            if(!FormMain.Instance.MetroContainer.Controls.ContainsKey("Settings"))
            {
                Settings settings = new Settings();
                settings.Dock = DockStyle.Fill;
                FormMain.Instance.MetroContainer.Controls.Add(settings);
            }
            FormMain.Instance.UserControl.Add("Settings");
            FormMain.Instance.MetroContainer.Controls["Settings"].BringToFront();
            FormMain.Instance.Back.Visible = true;
        }

        private void isClicked(object button)
        {
            foreach(Control btn in mpNav.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn == button)
                    {
                        btn.BackColor = Color.FromArgb(50, 12, 61);
                    } else
                    {
                        btn.BackColor = Color.FromArgb(129, 45, 148);
                    }
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("InventorySettings"))
            {
                InventorySettings uc = new InventorySettings();
                uc.Dock = DockStyle.Fill;
                FormMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FormMain.Instance.UserControl.Add("InventorySettings");
            FormMain.Instance.MetroContainer.Controls["InventorySettings"].BringToFront();
            FormMain.Instance.Back.Visible = true;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("PointOfSale"))
            {
                PointOfSale uc = new PointOfSale();

                uc.Dock = DockStyle.Fill;
                FormMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FormMain.Instance.UserControl.Add("PointOfSale");
            FormMain.Instance.MetroContainer.Controls["PointOfSale"].BringToFront();
            FormMain.Instance.Back.Visible = true;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            isClicked(btnExpenses);
            if (!mPanel.Controls.ContainsKey("Expenses"))
            {
                expenses = new Expenses();
                expenses.Dock = DockStyle.Fill;
                mPanel.Controls.Add(expenses);
            }
            expenses.LoadData();
            mPanel.Controls["Expenses"].BringToFront();
        }
    }
}
