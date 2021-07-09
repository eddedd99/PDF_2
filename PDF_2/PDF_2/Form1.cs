using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Root.Reports;

namespace PDF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report(new PdfFormatter());
            FontDef fd = new FontDef(report, "Helvetica");
            FontProp fp = new FontPropMM(fd, 15);
            Page page = new Page(report);
            //page.AddCenteredMM(80, new RepString(fp, "Hello World!"));
            page.AddCB_MM(80, new RepString(fp, "Hello World!"));
            RT.ViewPDF(report, "HelloWorld.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report report = new Report(new PdfFormatter());
            FontDef fd = new FontDef(report, "Helvetica");
            FontProp fp = new FontPropMM(fd, 15);
            FontProp fp_Title = new FontPropMM(fd, 11);
            fp_Title.bBold = true;

            Page page = new Page(report);
            page.AddCB_MM(40, new RepString(fp_Title, "PDF Properties Sample"));
            fp_Title.rSizeMM = 8;
            page.AddCB_MM(100, new RepString(fp_Title, "First Page"));
            page.AddCB_MM(140, new RepString(fp, "Choose <Document Properties, Summary> from the"));
            page.AddCB_MM(180, new RepString(fp, "File menu to display the document properties"));

            Page page2 = new Page(report);
            page2.AddCB_MM(100, new RepString(fp_Title, "Second Page"));
            RT.ViewPDF(report, "HelloWorld2.pdf");
        }
    }
}
