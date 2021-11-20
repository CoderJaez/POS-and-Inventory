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
using static Repository.DatabaseConnection;
using PurpleYam_POS.Model;
using PurpleYam_POS.helper;
using System.Drawing.Drawing2D;

namespace PurpleYam_POS
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        private UserProfile ucProfile;
        static FormMain _instance;
        public List<string> UserControl = new List<string>();
        private bool isClicked = false;
        public Panel UserPanel { get { return panelUser; } }
        public UserModel UserProfile { get; set; }
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
            panelUser.Visible = false;
            mlBack.Visible = false;
            
            if(IsDBConnected())
            {
                if(!MainPanel.Controls.ContainsKey("Login"))
                {
                    var uc = new Login();
                    uc.Dock = DockStyle.Fill;
                    uc.MainPanel.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - uc.MainPanel.Width) / 2,
                              (Screen.PrimaryScreen.WorkingArea.Height - uc.MainPanel.Height) / 4);
                    MainPanel.Controls.Add(uc);
                }
                MainPanel.Controls["Login"].BringToFront();
            } else
            {

                if (!MainPanel.Controls.ContainsKey("DatabaseConfig"))
                {
                    var uc = new DatabaseConfig();
                    uc.Dock = DockStyle.Fill;
                  
                    MainPanel.Controls.Add(uc);
                }
                MainPanel.Controls["DatabaseConfig"].BringToFront();
            }
            //Dashboard uc = new Dashboard();
            //uc.Dock = DockStyle.Fill;
            //MainPanel.Controls.Add(uc);
            
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            MainPanel.Controls[UserControl.Last()].SendToBack();
            UserControl.RemoveAt(UserControl.Count - 1);

            mlBack.Visible = (UserControl.Count > 0);
        }

        private void lblFullname_MouseHover(object sender, EventArgs e)
        {
            flpUserOptions.Visible = true;
        }

       
        public void SetUserProfile()
        {
            panelUser.Visible = true;
            pbUser.Image = ImageLoader.ImageFromStream(UserProfile.Customer.Image);
            lblFullname.Text = UserProfile.Fullname;
        }
       

        private void lblFullname_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            lblFullname.Image = isClicked ? Properties.Resources.sort_down : Properties.Resources.sort_right;
            flpUserOptions.Visible = isClicked;
        }

        private void flpUserOptions_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = false;
            flpUserOptions.Visible = isClicked;
            lblFullname.Image = isClicked ? Properties.Resources.sort_down : Properties.Resources.sort_right;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelUser.Visible = false;
            MainPanel.Controls["Login"].BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(!MetroContainer.Controls.ContainsKey("UserProfile"))
            {
                ucProfile = new UserProfile();
                ucProfile.Dock = DockStyle.Fill;
                MetroContainer.Controls.Add(ucProfile);
            }
            Back.Visible = true;
            UserControl.Add("UserProfile");
            MetroContainer.Controls["UserProfile"].BringToFront();

            ucProfile.SetProfile();
        }
    }
}
