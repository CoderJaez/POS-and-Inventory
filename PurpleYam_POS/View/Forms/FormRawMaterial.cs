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
        private static RawMaterialVM vModel;
        public static FormRawMaterial instance;
        public static FormRawMaterial Instance(RawMaterialVM _vModel)
        {
            vModel = _vModel;
                instance = new FormRawMaterial();
            return instance;
        }

        public MetroFramework.Controls.MetroTextBox mtProduct
        {
            get { return mtProductName; }
        }

        public FormRawMaterial()
        {
            InitializeComponent();
            rawMaterialsModelBindingSource = vModel.page.bindingSource;
            btnSave.Click += delegate {
                vModel.model.Product = mtProductName.Text;
                 vModel.SaveRawMat();
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRawMaterial_Load(object sender, EventArgs e)
        {
            if(vModel.model != null)
            {
                mtProductName.Text = vModel.model.Product;
            }

        }
    }
}
