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
namespace PurpleYam_POS.View.UserControls
{
    public partial class InventorySettings : UserControl
    {
        private InventoryViewModel viewModel;
        private Font tagFont = new Font("Century Gothic", 11, FontStyle.Bold);
        public Panel MainPanel
        {
            get { return mPanel; }
        }
        public InventorySettings()
        {
            InitializeComponent();
            viewModel = new InventoryViewModel();
            viewModel.ucInventorySettings = this;
            tvInventoryMenu.NodeMouseClick += viewModel.InventoryMenu;
        }

        private void tvInventoryMenu_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Draw the background and node text for a selected node.
            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                // Draw the background of the selected node. The NodeBounds
                // method makes the highlight rectangle large enough to
                // include the text of a node tag, if one is present.
                e.Graphics.FillRectangle(Brushes.Purple, NodeBounds(e.Node));

                // Retrieve the node font. If the node font has not been set,
                // use the TreeView font.
                Font nodeFont = e.Node.NodeFont;
                if (nodeFont == null) nodeFont = ((TreeView)sender).Font;

                // Draw the node text.
                e.Graphics.DrawString(e.Node.Text, tagFont, Brushes.White,e.Bounds);
            }

            // Use the default background and node text.
            else
            {
                e.DrawDefault = true;
            }

            //// If a node tag is present, draw its string representation 
            //// to the right of the label text.
            //if (e.Node.Tag != null)
            //{
            //    e.Graphics.DrawString(e.Node.Tag.ToString(), tagFont,
            //        Brushes.Purple, e.Bounds.Right + 2, e.Bounds.Top);
            //}

            //// If the node has focus, draw the focus rectangle large, making
            //// it large enough to include the text of the node tag, if present.
            //if ((e.State & TreeNodeStates.Focused) != 0)
            //{
            //    using (Pen focusPen = new Pen(Color.Black))
            //    {
            //        focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //        Rectangle focusBounds = NodeBounds(e.Node);
            //        focusBounds.Size = new Size(focusBounds.Width,
            //        focusBounds.Height);
            //        e.Graphics.DrawRectangle(focusPen, focusBounds);
            //    }
            //}
        }

        private Rectangle NodeBounds(TreeNode node)
        {
            // Set the return value to the normal node bounds.
            Rectangle bounds = node.Bounds;
            if (node.Tag != null)
            {
                // Retrieve a Graphics object from the TreeView handle
                // and use it to calculate the display width of the tag.
                Graphics g = tvInventoryMenu.CreateGraphics();
                int tagWidth = (int)g.MeasureString
                    (node.Tag.ToString(), tagFont).Width + 6;

                // Adjust the node bounds using the calculated value.
                bounds.Offset(tagWidth / 2, 0);
                bounds = Rectangle.Inflate(bounds, tagWidth , 0);
                g.Dispose();
            }

            return bounds;
        }
    }
}
