using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MergePDFsTool
{
    public partial class MainForm : Form
    {

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DlgBrowsePDFs.ShowDialog();
                if (DlgBrowsePDFs.FileNames != null && DlgBrowsePDFs.FileNames.Count() > 0)
                {
                    foreach (string FileName in DlgBrowsePDFs.FileNames)
                    {
                        if (SelectedFilesText.Text.Trim() != string.Empty)
                        {
                            SelectedFilesText.Text = SelectedFilesText.Text.Trim() + "\r\n" + FileName;
                        }
                        else
                        {
                            SelectedFilesText.Text = FileName;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while trying to browse the files");
            }
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DlgSaveMergedFile.ShowDialog();

                if (!string.IsNullOrEmpty(DlgSaveMergedFile.FileName))
                {
                    _logger.Info("Merging to {0}", DlgBrowsePDFs.FileName);
                    // step 1: creation of a document-object
                    PdfDocument document = new PdfDocument();

                    // step 2: we create a writer that listens to the document
                    //PdfCopy writer = new PdfCopy(document, new FileStream(DlgSaveMergedFile.FileName, FileMode.Create));
                    //if (writer == null)
                    //{
                    //    return;
                    //}
                    bool HasAnythingFailed = false;
                    // step 3: we open the document
                    //document.Open();
                    try
                    {
                        foreach (string FileName in SelectedFilesText.Text.Split(new char[] { '\r', '\n' }))
                        {
                            try
                            {
                                var FileNametrunc = FileName.Trim().Replace("\r\n", string.Empty);
                                if (!string.IsNullOrEmpty(FileNametrunc))
                                {
                                    _logger.Info("Merging- {0}", FileNametrunc);
                                    // we create a reader for a certain document
                                   PdfDocument reader = PdfReader.Open(FileNametrunc,PdfDocumentOpenMode.Import);
                                    for(int i=0;i<reader.PageCount;i++)
                                    {
                                        PdfPage page = reader.Pages[i];
                                        document.AddPage(page);
                                    }

                                    reader.Close();
                                }
                            }
                            catch (Exception inner1)
                            {
                                _logger.Error(inner1, "Error inside the for loop");
                                HasAnythingFailed = true;
                            }
                        }
                        //Try and save the document
                        document.Save(DlgSaveMergedFile.FileName);
                    }
                    catch (Exception inner2)
                    {
                        _logger.Error(inner2, "Error outside the loop");
                    }
                    finally
                    {
                        _logger.Info("Merge completed!");
                        document.Close();
                        if (HasAnythingFailed)
                        {
                            _logger.Info("One or more files has failed!");
                            MessageBox.Show("One or more files has failed to parse. Please fix it, refer to the logs for more details\n\nMerge Complated with errors");
                        }
                        else
                        {
                            MessageBox.Show("Merge completed!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while trying to convert the files");
            }
            finally
            {

            }
        }

        private void ClearFilesButton_Click(object sender, EventArgs e)
        {
            SelectedFilesText.Text = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _logger.Info("Application Launched!");
        }
    }
}
