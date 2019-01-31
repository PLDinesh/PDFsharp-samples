using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf.IO;
using NLog;

namespace SampleParser
{
    public partial class MainForm : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private static string ApplicationName = "Dinesh TimeSheet Reminder";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog();
            if (!string.IsNullOrEmpty(dlgOpenFile.FileName))
            {
                TxtFileName.Text = dlgOpenFile.FileName;
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFileName.Text))
            {
                return;
            }
            PdfSharp.Pdf.PdfDocument oDoc = PdfReader.Open(TxtFileName.Text);
            StringBuilder sb = new StringBuilder("");
            foreach (PdfSharp.Pdf.PdfPage PDFPAge in oDoc.Pages)
            {
                var op = PDFPAge.ExtractText();
                foreach (var str in op )
                {
                    sb.Append(str);
                    _logger.Debug(str);
                }
            }
            TxtContents.Text = sb.ToString();
        }
    }
}
