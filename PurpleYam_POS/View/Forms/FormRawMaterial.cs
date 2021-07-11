using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormRawMaterial : MetroFramework.Forms.MetroForm
    {
        private static RawMaterialsModel model;
        private static RawMaterialVM vModel;
        public static FormRawMaterial Instance(RawMaterialVM _vModel, RawMaterialsModel _model)
        {
            model = _model;
            vModel = _vModel;
            return new FormRawMaterial();
        }
        public FormRawMaterial()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
