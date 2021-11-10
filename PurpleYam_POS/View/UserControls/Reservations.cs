using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Reservations : UserControl
    {
        public DataGridView DgReservation { get { return dgReservations; } }
        public ReservationViewModel viewModel;

        public string Search { get {return tbSearch.Text; } set { tbSearch.Text = value; } }
        public DateTime DateReservation { get {return dtpReservation.Value; }  }

        public Reservations()
        {
            InitializeComponent();
            viewModel = new ReservationViewModel();
            viewModel.ucReservation = this;
            viewModel.ProductBS = ProductBS;
            viewModel.ReservationBS = ReservationBS;
            dgOrders.DataBindingComplete += delegate { dgOrders.ClearSelection(); };
            dgReservations.DataBindingComplete += delegate { dgReservations.ClearSelection(); };
            btnClear.Click += delegate { viewModel.ClearOrders(); };
            dgReservations.CellClick += viewModel.DgSettlePayment;
        }


        public void LoadData()
        {
            viewModel.LoadReservation();
            dgReservations.ClearSelection();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }

        private void dtpReservation_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
