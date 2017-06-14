using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licencjatt
{
    public partial class PdfViewer : UserControl
    {
        private string pdfFilePath;

        public PdfViewer()
        {
            InitializeComponent();
            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.setView("FitH");
        }

        public string PdfFilePath
        {
            get
            {
                return pdfFilePath;
            }

            set
            {
                if (pdfFilePath != value)
                {
                    pdfFilePath = value;
                    ChangeCurrentDisplayedPdf();
                }
            }
        }

        public void Print()
        {
            axAcroPDF1.printWithDialog();
        }

        private void ChangeCurrentDisplayedPdf()
        {
            axAcroPDF1.LoadFile(PdfFilePath);
            axAcroPDF1.src = PdfFilePath;
            axAcroPDF1.setViewScroll("FitH", 0);
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
