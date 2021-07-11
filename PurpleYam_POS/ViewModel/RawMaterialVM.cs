using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.View.Forms;
namespace PurpleYam_POS.ViewModel
{
    public class RawMaterialVM
    {
        public BindingSource rawMatBindingSource { get; set; }
        public void LoadData()
        {
            var list = new List<RawMaterialsModel>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new RawMaterialsModel()
                {
                    Id = i,
                    CreatedAt = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"),
                    Product = $"Product-{i.ToString("D4")}",
                    DisplayUnit = $"DisplayUnit-{i.ToString("D4")}",
                    BaseUnit = $"BaseUnit-{i.ToString("D4")}",
                    Deleted = false
                });
            }
            rawMatBindingSource.DataSource = list;
        }

        public void rawMatCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            var obj = rawMatBindingSource.Current as RawMaterialsModel;
            MessageBox.Show(obj.Product);
        }

        public void New()
        {
            FormRawMaterial.Instance(this, new RawMaterialsModel()).ShowDialog();   
        }
    }
}
