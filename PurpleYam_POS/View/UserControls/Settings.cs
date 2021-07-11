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
    public partial class Settings : MetroFramework.Controls.MetroUserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu(object button, EventArgs e)
        {
            Button btn = (Button)button;
            isClicked(btn);

            switch (btn.Name)
            {
                case "btnUnits":
                    if (!mPanel.Controls.ContainsKey("Units"))
                    {
                        Units units = new Units();
                        units.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(units);
                    }
                    mPanel.Controls["Units"].BringToFront();
                    break;

                case "btnUserRoles":
                    if (!mPanel.Controls.ContainsKey("UserRoles"))
                    {
                        UserRoles uc = new UserRoles();
                        uc.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(uc);
                    }
                    mPanel.Controls["UserRoles"].BringToFront();
                    break;

                case "btnRawMaterials":
                    if (!mPanel.Controls.ContainsKey("RawMaterials"))
                    {
                         var uc = RawMaterials.Instance;
                        uc.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(uc);
                    }
                    mPanel.Controls["RawMaterials"].BringToFront();
                    break;
            }
        }

        private void isClicked(object button)
        {
            foreach (Control btn in mpNav.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn == button)
                    {
                        btn.BackColor = Color.FromArgb(50, 12, 61);
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(129, 45, 148);
                    }
                }
            }
        }
    }
}
