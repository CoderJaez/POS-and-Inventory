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
using MetroFramework.Controls;

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


        public MetroFramework.Controls.MetroTextBox mtQuantity
        {
            get { return mtQty; }
        }

        public Button NewRawmat
        {
            get { return btnNewRawmat; }
        }
        public Button btnSaveRawmatUnit
        {
            get { return btnSaveUnit; }
        }

        public Button btnSaveRawmat
        {
            get { return btnSave; }
        }

        public MetroFramework.Controls.MetroComboBox mcunitCode
        {
            get { return mcUnitCode; }
        }

        public MetroTextBox MtbDaysBeforeExypiry
        {
            get { return mtbDaysBeforeExpiry; }
        }
        public CheckBox ChBxHasExpiry
        {
            get { return cbxHasExpiry; }
        }
        public DataGridView dgRawmatunit
        {
            get { return dgRawMat; }
        }
        public FormRawMaterial()
        {
            InitializeComponent();
            RawMatBS = vModel.page.bindingSource;
            vModel.PrudUnitBS = ProductUnitBS;
            vModel.UnitCodeBS = UnitCodeBS;
            dgRawMat.CellClick += vModel.cbBaseDisplayCellClick;
            mcUnitCode.SelectedValueChanged += vModel.mcUnitCodeSelectedValueChanged;
            btnNewRawmat.Click += delegate
             {
                 vModel.model = new RawMaterial();
                 mtProduct.Text = null;
                 mtbReOrder.Text = null;
                 mtbDaysBeforeExpiry.Text = null;
                 cbxHasExpiry.Checked = false;
                 btnNewRawmat.Enabled = false;
                 btnSave.Enabled = true;
             };
            btnSaveUnit.Click += delegate
            {
                vModel.SaveRawMatUnit();
            };
            btnSave.Click += delegate {
                vModel.model.Product = mtProductName.Text;
                vModel.model.HasExpiry = cbxHasExpiry.Checked;
                vModel.model.ReOrder = !string.IsNullOrEmpty(mtbReOrder.Text) ? int.Parse(mtbReOrder.Text) : 0;
                vModel.model.DaysBeforeExpiry = !string.IsNullOrEmpty(mtbDaysBeforeExpiry.Text) ? int.Parse(mtbDaysBeforeExpiry.Text) : 0;
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
                vModel.LoadRawMatUnit();
            }

        }

        private void mtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void cbxHasExpiry_CheckedChanged(object sender, EventArgs e)
        {
            mtbDaysBeforeExpiry.Enabled = cbxHasExpiry.Checked;
        }
    }
}
