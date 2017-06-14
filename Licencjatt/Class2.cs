using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Licencjatt
{
    public class PdfViewerHost1 : WindowsFormsHost
    {
        public static readonly DependencyProperty PdfPathProperty = DependencyProperty.Register(
         "PdfPath", typeof(string), typeof(PdfViewerHost1), new PropertyMetadata(PdfPathPropertyChanged));

        private readonly PdfViewer2 wrappedControl;

        public PdfViewerHost1()
        {
            wrappedControl = new PdfViewer2();
            Child = wrappedControl;
        }

        public string PdfPath
        {
            get
            {
                return (string)GetValue(PdfPathProperty);
            }

            set
            {
                SetValue(PdfPathProperty, value);
            }
        }

        public void Print()
        {
            wrappedControl.Print();
        }

        private static void PdfPathPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PdfViewerHost1 host = (PdfViewerHost1)d;
            host.wrappedControl.PdfFilePath = (string)e.NewValue;
        }
    }
}
