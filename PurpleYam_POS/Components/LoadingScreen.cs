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

        public ProgressBar ProgressBar
        {
            get { return progressBar; }
        }

        public LoadingScreen()
        {
            InitializeComponent();
        }
    }
}
