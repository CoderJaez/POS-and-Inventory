using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Settings : MetroFramework.Controls.MetroUserControl
    {
        //UserControls
        private Units units;
        private RawMaterials rawMat;
        private Products products;
        private AddOns addons;
        private ExpensesSettings expenseSettings;
        public Settings()
        {
            InitializeComponent();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu(object button, EventArgs e)
        {
            Button btn = (Button)button;
            isClicked(btn);

            switch (btn.Name)
            {
                case "btnUnits":
                    if (!mPanel.Controls.ContainsKey("Units"))
                    {
                        units = new Units();
                        units.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(units);
                    }
                    mPanel.Controls["Units"].BringToFront();
                    break;
                case "btnRawMaterials":
                    if (!mPanel.Controls.ContainsKey("RawMaterials"))
                    {
                         rawMat = new RawMaterials();
                        rawMat.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(rawMat);
                    }
                    mPanel.Controls["RawMaterials"].BringToFront();
                    rawMat.LoadData();
                    break;
                case "btnProducts":
                    if (!mPanel.Controls.ContainsKey("Products"))
                    {
                        products = new Products();
                        products.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(products);
                    }
                    mPanel.Controls["Products"].BringToFront();
                    products.LoadData();
                    break;

                case "btnAddons":
                    if (!mPanel.Controls.ContainsKey("Addons"))
                    {
                        addons = new AddOns();
                        addons.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(addons);
                    }
                    mPanel.Controls["AddOns"].BringToFront();
                    addons.LoadData();
                    break;
                case "btnExpenses":
                    if(!mPanel.Controls.ContainsKey("ExpensesSettings"))
                    {
                        expenseSettings = new ExpensesSettings();
                        expenseSettings.Dock = DockStyle.Fill;
                        mPanel.Controls.Add(expenseSettings);
                    }
                    mPanel.Controls["ExpensesSettings"].BringToFront();
                    expenseSettings.LoadData();
                    break;
            }
        }

        private void isClicked(object button)
        {
            foreach (Control btn in mpNav.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn == button)
                    {
                        btn.BackColor = Color.FromArgb(50, 12, 61);
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(129, 45, 148);
                    }
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
