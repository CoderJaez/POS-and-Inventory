using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;
namespace PurpleYam_POS.Components
{
    public static class Notification
    {
     
        public enum AlertType
        {
            WARNING,
            SUCCESS,
            ERROR,
            INFO,
        }
        public  static void AlertMessage(string message, string title,  AlertType type )
        {
            var alert = new PopupNotifier();
            alert.TitleText = title;
            alert.ContentText = message;
            alert.TitleFont = new Font("Segeo UI", 12);
            alert.TitlePadding = new System.Windows.Forms.Padding(10,5,0,5);
            alert.ImagePadding = new System.Windows.Forms.Padding(5,5,0,0);
            alert.ContentPadding = new System.Windows.Forms.Padding(5);
            alert.ContentFont = new Font("Segeo UI", 10);
            switch (type)
            {
                case AlertType.ERROR:
                    alert.Image = Properties.Resources.Error;
                    alert.HeaderColor = Color.FromArgb(152, 33, 0);
                    break;
                case AlertType.WARNING:
                    alert.Image = Properties.Resources.warning;
                    alert.HeaderColor = Color.FromArgb(163, 105, 39);
                    break;
                case AlertType.SUCCESS:
                    alert.Image = Properties.Resources.Success;
                    alert.HeaderColor = Color.FromArgb(0, 152, 67);
                    break;
                case AlertType.INFO:
                    alert.Image = Properties.Resources.info;
                    alert.HeaderColor = Color.FromArgb(0, 131, 152);
                    break;
            }

            alert.Popup();
        }

        public static DialogResult Confim(FormMain form, string message, string title)
        {
            return MetroFramework.MetroMessageBox.Show(form, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ValidationMessage(FormMain form, string message, string title)
        {
            MetroFramework.MetroMessageBox.Show(form, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       
     
    }
}
