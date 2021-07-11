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
using PurpleYam_POS.Model;

namespace PurpleYam_POS.View.UserControls
{
    public partial class RawMaterials : MetroFramework.Controls.MetroUserControl
    {
        RawMaterialVM rawMatVM;
        private static RawMaterials _instance;
        public static RawMaterials Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RawMaterials();
                return _instance;
            }
        }
        public RawMaterials()
        {
            InitializeComponent();
            rawMatVM = new RawMaterialVM();
            rawMatVM.rawMatBindingSource = rawMaterialsModelBindingSource;
            rawMatVM.LoadData();
            dgRawMat.CellClick += rawMatVM.rawMatCellClick;
            btnAdd.Click += delegate { rawMatVM.New(); };
        }

      
    }
}
