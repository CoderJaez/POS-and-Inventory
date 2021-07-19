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
using PurpleYam_POS.ViewModel;
using PurpleYam_POS.Model;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Units : MetroFramework.Controls.MetroUserControl
    {
        UnitViewModel unitVM;

        public Units()
        {
            InitializeComponent();
            unitVM = new UnitViewModel();
            unitVM.UnitBindingSource = unitBindingSource;
            btnAdd.Click += delegate { unitVM.New(new Unit()); };
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {

                Unit unit = unitBindingSource.Current as Unit;
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        unitVM.New(unit);
                        break;
                    case "delete":
                        unitVM.Delete(unit);
                        break;
                }
            }
        }

        private async void Units_Load(object sender, EventArgs e)
        {
          await  unitVM.LoadDataAsync();
        }
    }
}
