using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Model;

namespace PurpleYam_POS.helper
{
    public class PrintReceipt
    {
        private string Header { get; set; }
        private string Body { get; set; }
        private string Footer { get; set; }
        private int prntAreaWidth = 0;
        private string StringToPrnt;
        float leading = 4;
        Font bft = new Font("Arial Narrow", 7);
        Font hft = new Font("Arial Narrow", 12);
        float startX = 0;
        float startY = 0;
        float lineheight12 = 0;
        float lineheight10 = 0;
        Graphics g;
        float offsetY = 0;
        private  PrintDocument receipt;
        private static PrintReceipt _instance;
        private List<SoldProductModel> orders;
        private SaleTransactionModel st;

        public static PrintReceipt Instance
        {
            get {
                if (_instance == null)
                    _instance = new PrintReceipt();
                return   _instance;
            }
        }

        public PrintReceipt()
        {
            receipt = new PrintDocument();
            receipt.PrintPage += ReceiptDoc_PrintPage;

        }


        private static string getStrSplit(string x, int length)
        {
            string result = string.Empty;
            if (x.Length <= length)
            {
                return x;
            }
            else
            {
                var sub = x.Substring(0, length);
                result += sub + "\n" + getStrSplit(x.Replace(sub, ""), length);
            }
            return result;
        }

        private string itemFormat(string item, decimal qty, decimal price, decimal amnt)
        {
            lineheight10 = bft.GetHeight() + leading;
            var outStr = getStrSplit(item, 10);
            var outlst = outStr.Split('\n').ToList();
            string output = string.Empty;
            output += string.Format("{0,-10}{1,10:N2}{2,8:N2}\n", qty + " " + outlst[0], price, " " + amnt);
            if (outlst.Count > 1)
            {
                foreach (var i in outlst.Skip(1))
                {
                    output += string.Format("{0,-10}\n", "   " + i);
                }
            }

            if (outlst.Count > 1 && outlst.Count <= 2)
                offsetY += lineheight10 + 15;
            else if (outlst.Count > 2)
                offsetY += lineheight10 + 32;
            else
                offsetY += lineheight10;
            return output;
        }

        public void PrintReciept(BindingSource _orders, SaleTransactionModel _st)
        {
            orders = _orders.List.OfType<SoldProductModel>().ToList();
            st = _st;
            receipt.DocumentName = $"Orders-{st.TransactionNo}";
            receipt.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 190, int.MaxValue);
            prntAreaWidth = receipt.DefaultPageSettings.PaperSize.Width;


            Body += string.Format("{0,-10}{1,10:N2}{2,10:N2}\n", "Description", "Price", "Amnt");

            orders.ForEach(p =>
            {
                Body += itemFormat(p.Product, p.Qty, p.Price, p.SubTotal);
            });
            
            receipt.Print();
            //ppd.Document = ReceiptDoc;
            //ppd.ShowDialog();
        }


        private void ReceiptDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            startY = leading;
            lineheight12 = hft.GetHeight() + leading;
            lineheight10 = bft.GetHeight() + leading;
            StringFormat formatleft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatleft);
            StringFormat formatRight = new StringFormat(formatleft);
            float offset = 0;
            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatleft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(prntAreaWidth - offset * 2, lineheight12);
            RectangleF layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(Properties.Settings.Default.BusinessName.ToUpper(), hft, new SolidBrush(Color.Black), layout, formatCenter);//Business Name;
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(Properties.Settings.Default.Header1, bft, new SolidBrush(Color.Black), layout, formatCenter); //Address


            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString(Properties.Settings.Default.Header2, bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"Trans#:{st.TransactionNo}", bft, new SolidBrush(Color.Black), layout, formatleft);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"Date:{(st.TransactionType == "RESERVATION" ? st.ReservationDate :DateTime.Now)}", bft, new SolidBrush(Color.Black), layout, formatleft);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"Order by: {(st.TransactionType == "RESERVATION" ? st.Fullname :"Walk-In")}", bft, new SolidBrush(Color.Black), layout, formatleft);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"Contact No :{st.Customer.ContactNo}", bft, new SolidBrush(Color.Black), layout, formatleft);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter);
            offset += lineheight10;
            //int i = 1;
            e.Graphics.DrawString(Body, bft, new SolidBrush(Color.Black), new Point((int)startX, (int)startY + (int)offset));
            offset += lineheight10 + offsetY;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString($"{orders.Count} ITEM(S)", bft, new SolidBrush(Color.Black), layout, formatleft);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("TOTAL", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.TotalAmount.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("Down", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.DownPayment.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("Balance", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.Balance.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("CASH RCVD", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.CashTendered.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("CHANGE", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.Change.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter); //Contact No

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("VAT SALES", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.SubTotal.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("Vat", bft, new SolidBrush(Color.Black), layout, formatleft);
            e.Graphics.DrawString(st.Vat.ToString("N"), bft, new SolidBrush(Color.Black), layout, formatRight);

            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("===========================", bft, new SolidBrush(Color.Black), layout, formatCenter);
            offset += lineheight10;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("THIS IS NOT AN OFFICIAL RECIEPT", bft, new SolidBrush(Color.Black), layout, formatCenter);
            offset += lineheight10 * 2;
            layout = new RectangleF(new PointF(startX, startY + offset), layoutSize);
            e.Graphics.DrawString("HAVE A NICE DAY!", bft, new SolidBrush(Color.Black), layout, formatCenter);
        }


    }
}
