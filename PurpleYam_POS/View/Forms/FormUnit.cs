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
using PurpleYam_POS.Model;
namespace PurpleYam_POS.View.Forms
{
   
    public partial class FormUnit : MetroFramework.Forms.MetroForm
    {
        static UnitViewModel unitVM;
        private static Unit unit;
        public static FormUnit Instance(UnitViewModel _unitVM, Unit _unit)
        {
            unitVM = _unitVM;
            unit = _unit;
            return new FormUnit();
        }   
        public FormUnit()
        {
            InitializeComponent();
            unitBindingSource = unitVM.UnitBindingSource;
            btnSave.Click += delegate {
                unit.UnitCode = mtUnitCode.Text;
                unit.UnitDesc = mtUnitDesc.Text;
                unitVM.Save(unit);
            };

        }

        private void FormUnit_Load(object sender, EventArgs e)
        {
            if(unit != null)
            {
                mtUnitCode.Text = unit.UnitCode;
                mtUnitDesc.Text = unit.UnitDesc;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
