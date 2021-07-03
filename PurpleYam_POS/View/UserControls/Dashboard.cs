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
            if(!mPanel.Controls.ContainsKey("Summary"))
            {
                Summary summary = new Summary();
                summary.Dock = DockStyle.Fill;
                mPanel.Controls.Add(summary);
            }
            mPanel.Controls["Summary"].BringToFront();
        }

        private void mbTransaction_Click(object sender, EventArgs e)
        {
            if (!mPanel.Controls.ContainsKey("SaleTransaction"))
            {
                SaleTransaction sales = new SaleTransaction();
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
            FormMain.Instance.MetroContainer.Controls["Settings"].BringToFront();
            FormMain.Instance.Back.Visible = true;
        }
    }
}
