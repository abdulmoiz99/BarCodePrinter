using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodePrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Label", 2, 1);
            Graphics drawing = e.Graphics;
            drawing.Clear(Color.White);
            Brush textBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial Narrow", 14, FontStyle.Bold);
            Font fontBig = new Font("Arial Narrow", 36, FontStyle.Bold);
            drawing.DrawString("SHELF:", font, textBrush, 10, 15);
            drawing.DrawString("49", fontBig, textBrush, 80, 5);
            drawing.DrawString("SKU: 9517-28", font, textBrush, 10, 80);
            drawing.DrawString("COUNT: 14", font, textBrush, 150, 80);

            textBrush.Dispose();
            drawing.Dispose();         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrintDocument1.Print();
        }
    }
}
