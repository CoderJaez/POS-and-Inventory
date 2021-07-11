using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.View.Forms;

namespace PurpleYam_POS.View.UserControls
{
    public partial class UserRoles : MetroFramework.Controls.MetroUserControl
    {
        public UserRoles()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frmUserRole = new FormUserRoles())
            {
                frmUserRole.ShowDialog();
            }
        }
    }
}
