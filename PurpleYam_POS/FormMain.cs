using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.View.UserControls;
namespace PurpleYam_POS
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
         static FormMain _instance;

        public static FormMain Instance {
            get {
                if (_instance == null)
                    _instance = new FormMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return MainPanel; }
            set { MainPanel = value; }

        }

        public MetroFramework.Controls.MetroLink Back {
            get
            {
                return mlBack;
            }
            set { mlBack = value; }
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            Dashboard uc = new Dashboard();
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(uc);
            
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            MainPanel.Controls["Dashboard"].BringToFront();
            mlBack.Visible = false;
        }
    }
}
