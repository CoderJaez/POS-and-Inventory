using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormTransaction : Form
    {
        private PosViewModel viewModel;

        public FormTransaction(PosViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;

        }

        private void trasactionClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if((string)btn.Tag == "reservation")
                viewModel.transactionType = PosViewModel.Transaction.RESERVATION;
             else
                viewModel.transactionType = PosViewModel.Transaction.WALK_IN;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
