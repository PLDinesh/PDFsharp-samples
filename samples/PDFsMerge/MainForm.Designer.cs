namespace MergePDFsTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DlgBrowsePDFs = new System.Windows.Forms.OpenFileDialog();
            this.SelectedFilesText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.DlgSaveMergedFile = new System.Windows.Forms.SaveFileDialog();
            this.ClearFilesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DlgBrowsePDFs
            // 
            this.DlgBrowsePDFs.Filter = "PDF Files|*.pdf|All Files|*.*";
            this.DlgBrowsePDFs.Multiselect = true;
            // 
            // SelectedFilesText
            // 
            this.SelectedFilesText.Location = new System.Drawing.Point(41, 69);
            this.SelectedFilesText.MaxLength = 4500000;
            this.SelectedFilesText.Multiline = true;
            this.SelectedFilesText.Name = "SelectedFilesText";
            this.SelectedFilesText.Size = new System.Drawing.Size(1031, 542);
            this.SelectedFilesText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Files";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(313, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(179, 39);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse For PDFs";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.Location = new System.Drawing.Point(1092, 161);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(135, 66);
            this.MergeButton.TabIndex = 3;
            this.MergeButton.Text = "Merge files && Save";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // DlgSaveMergedFile
            // 
            this.DlgSaveMergedFile.Filter = "PDF Files|*.pdf|All Files|*.*";
            // 
            // ClearFilesButton
            // 
            this.ClearFilesButton.Location = new System.Drawing.Point(531, 12);
            this.ClearFilesButton.Name = "ClearFilesButton";
            this.ClearFilesButton.Size = new System.Drawing.Size(179, 39);
            this.ClearFilesButton.TabIndex = 2;
            this.ClearFilesButton.Text = "Clear List";
            this.ClearFilesButton.UseVisualStyleBackColor = true;
            this.ClearFilesButton.Click += new System.EventHandler(this.ClearFilesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 643);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.ClearFilesButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedFilesText);
            this.Name = "MainForm";
            this.Text = "Merge PDFs (A Stuid application created by Dinesh because he was too lazy to goog" +
    "le for a Free tool)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DlgBrowsePDFs;
        private System.Windows.Forms.TextBox SelectedFilesText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.SaveFileDialog DlgSaveMergedFile;
        private System.Windows.Forms.Button ClearFilesButton;
    }
}

