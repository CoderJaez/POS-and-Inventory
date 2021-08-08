using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using PurpleYam_POS.View.UserControls;
using static Repository.DataAccess;

namespace PurpleYam_POS.helper
{
    public class Pagination
    {
        public int start = 0;
        public  int page = 1;
        public int limit = 50;
        public int totalRows = 0;
        public int filteredRows = 0;
        public int totalPage = 0;
        public string search;
        public string sql;
        public string fileteredQry;
        public string totalRowsQry;
        public BindingSource bindingSource { get; set; }
        //Controls
        public ComboBox cbPerPage;
        public Button btnLastPage;
        public Button btnFirstPage;
        public Button btnNext;
        public Button btnPrev;
        public Label pageLabel;
        public Label labelEntries;

        private FlowLayoutPanel panel;

        public Pagination(FlowLayoutPanel _panel)
        {
            panel = _panel;
            Initialize();
        }
        private void Initialize()
        {
            //cbPerPage
            cbPerPage = new ComboBox();
            cbPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPerPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerPage.FormattingEnabled = true;
            this.cbPerPage.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "500"});
            cbPerPage.Name = "cbPerPage";
            cbPerPage.Size = new System.Drawing.Size(67, 25);
            cbPerPage.TabIndex = 29;

            //btnLastPage
            btnLastPage = new Button();
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(55, 28);
            this.btnLastPage.TabIndex = 26;
            this.btnLastPage.Text = "Last";
            this.btnLastPage.UseVisualStyleBackColor = true;


            //btnFirstPage
            btnFirstPage = new Button();
            this.btnFirstPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(55, 28);
            this.btnFirstPage.TabIndex = 24;
            this.btnFirstPage.Text = "First";
            this.btnFirstPage.UseVisualStyleBackColor = true;


            // 
            // btnNext
            // 
            btnNext = new Button();
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 28);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev = new Button();
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(520, 589);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(55, 28);
            this.btnPrev.TabIndex = 25;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // pageLabel
            // 
            pageLabel = new Label();
            this.pageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel.Location = new System.Drawing.Point(433, 592);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(81, 23);
            this.pageLabel.TabIndex = 30;
            this.pageLabel.Text = "1/100";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            panel.Controls.Add(cbPerPage);
            panel.Controls.Add(btnFirstPage);
            panel.Controls.Add(btnLastPage);
            panel.Controls.Add(pageLabel);
            panel.Controls.Add(btnPrev);
            panel.Controls.Add(btnNext);
        }

        public async Task LoadDataTableAsync<T, U>(U p)
        {
            sql += $"LIMIT {start}, {limit}";
            bindingSource.DataSource = await Task.Run(() => LoadData<T, dynamic>(sql, p));
            if (search == "")
            {
                totalRows = GetTotalRows(totalRowsQry, new { });
                totalPage = (int)Math.Ceiling((double)totalRows / (double)limit);
                pageLabel.Text = $"{page}/{(totalPage)}";
                if (totalRows - start < limit)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }

                if (totalPage <= 1)
                {
                    btnFirstPage.Enabled = false;
                    btnLastPage.Enabled = false;
                }

            } else
            {
                filteredRows = GetTotalRows(fileteredQry, p);
                totalPage = (int)Math.Round((double)filteredRows / (double)limit);
                pageLabel.Text = $"{page}/{(totalPage != 0 ? totalPage : page)}";

                if (filteredRows - start < limit)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }
            }

            
        }


    }
}
