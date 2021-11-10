using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PurpleYam_POS.View.UserControls
{
    public partial class PrintPreview : UserControl
    {
        
        public PrintPreview()
        {
            InitializeComponent();
            
        }

        public void LoadPreview(ReportDataSource[] _rs, string _rdlc, ReportParameter[] _p = null)
        {
            rvReport.LocalReport.DataSources.Clear();
            foreach(ReportDataSource rs in _rs)
                rvReport.LocalReport.DataSources.Add(rs);
            rvReport.LocalReport.ReportEmbeddedResource = _rdlc;
            rvReport.LocalReport.SetParameters(_p);
            rvReport.RefreshReport();
        }
    }
}
