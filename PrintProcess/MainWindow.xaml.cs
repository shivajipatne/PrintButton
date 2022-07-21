using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps.Packaging;

namespace PrintProcess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>z
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("i am the outer button");
        }

        private void outEclipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("i am green eclipse");
        }

        private void InnButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("i am the inner button");
        }


        //###############print dialogue open ###################
        //private void button_click(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show("i am a button guys");

        //    PrintDialog dlg = new PrintDialog();
        //    dlg.ShowDialog();
        //}

        //###########################################################################
        //void button_click(Object sender, RoutedEventArgs args)
        //{
        //    PrintCommand();
        //}


        //private void PrintCommand()
        //{
        //    PrintDialog pd = new PrintDialog();
        //    if ((pd.ShowDialog() == true))
        //    {
        //        //use either one of the below
        //        pd.PrintVisual(EulaRichTextBox as Visual, "printing as visual");
        //        //pd.PrintDocument(((IDocumentPaginatorSource)richTB.Document).DocumentPaginator, "printing as paginator");
        //    }
        //}
        //####print button code to print the dialogue####################




        //private void button_click(object sender, RoutedEventArgs e)
        //{
        //    // Create the print dialog object and set options
        //    PrintDialog pDialog = new PrintDialog();
        //    pDialog.PageRangeSelection = PageRangeSelection.AllPages;
        //    pDialog.UserPageRangeEnabled = true;

        //    // Display the dialog. This returns true if the user presses the Print button.
        //    Nullable<Boolean> print = pDialog.ShowDialog();
        //    if (print == true)
        //    {
        //        XpsDocument xpsDocument = new XpsDocument("C:\\text.txt", FileAccess.ReadWrite);
        //        FixedDocumentSequence fixedDocSeq = xpsDocument.GetFixedDocumentSequence();
        //        pDialog.PrintDocument(fixedDocSeq.DocumentPaginator, "Test print job");
        //    }
        //}      
    }
}
