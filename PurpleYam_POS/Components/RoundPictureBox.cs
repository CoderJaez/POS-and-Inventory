using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace PurpleYam_POS.Components
{
    public class RoundPictureBox: PictureBox
    {
        public RoundPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
                base.OnPaint(e);
            }
        }
    }
}
