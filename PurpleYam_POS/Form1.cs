using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.viewmodel;
using PurpleYam_POS.model;
namespace PurpleYam_POS
{
    public partial class Form1 : Form
    {
        private Unit _unit;
        private UnitViewModel _unitVM;
        public Form1()
        {
            InitializeComponent();
            _unitVM = new UnitViewModel();
            _unitVM.UnitBindingSource = unitBindingSource;
            this.Load += delegate { _unitVM.Load(); };
            btnNew.Click += delegate { _unitVM.New(); };
            btnDelete.Click += delegate { _unitVM.Delete(); };
            btnSave.Click += delegate {
                _unit = new Unit
                {
                    Id = !string.IsNullOrWhiteSpace(idTextBox.Text) ? int.Parse(idTextBox.Text):0,
                    UnitCode = unitCodeTextBox.Text,
                    UnitDesc = unitDescTextBox.Text
                };
                _unitVM.Save(_unit);
                _unitVM.Load();
            }; 
           
        }
    }
}
