using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Repository.DatabaseConnection;
using PurpleYam_POS.Components;

namespace PurpleYam_POS.View.UserControls
{
    
    public partial class DatabaseConfig : UserControl
    {
        string conn;
        public string Server { get { return tbServer.Text; } set { tbServer.Text = value; } }
        public string  Username { get { return tbUsername.Text; } set { tbUsername.Text = value; } }
        public string  Database { get { return tbDatabase.Text; } set { tbDatabase.Text = value; } }
        public string Port { get { return tbPort.Text; } set { tbPort.Text = value; } }
        public string Password { get { return tbPassword.Text; } set { tbPassword.Text = value; } }
        public Panel MainPanel{ get { return panel1; } }

        public DatabaseConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsInValid())
            {
                Notification.ValidationMessage(FormMain.Instance, "All fields must not be empty", "Field/s empty");
                return;
            }

            conn = string.Format("host={0};user={1};pass={2};database={3};port={4};", Server, Username, Password, Database, Port);
            UpdateDBConfig(conn);
            Application.Restart();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsInValid())
            {
                Notification.ValidationMessage(FormMain.Instance, "All fields must not be empty", "Field/s empty");
                return;
            }

            conn = string.Format("host={0};user={1};pass={2};database={3};port={4};", Server, Username, Password, Database, Port);
            if (IsDBConnected(conn))
                Notification.AlertMessage("Connected successfully", "Success", Notification.AlertType.SUCCESS); 
            else
                Notification.AlertMessage(ErrMsg, "Connection failed", Notification.AlertType.ERROR);

        }

        private bool IsInValid()
        {
            return (string.IsNullOrEmpty(Server) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Database) || string.IsNullOrEmpty(Port));
        }
    }
}
