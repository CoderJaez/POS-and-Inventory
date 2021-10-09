using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurpleYam_POS.Components
{
    public partial class LoadingScreen : Form
    {
        public Label LabelLoading
        {
            get { return labelLoad; }
        }

        public Panel PanelChange
        {
            get { return panelChange; }
        }

        public string Change
        {
            get { return labelChange.Text; }
            set { labelChange.Text = value; }
        }
        public ProgressBar ProgressBar
        {
            get { return progressBar; }
        }

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
