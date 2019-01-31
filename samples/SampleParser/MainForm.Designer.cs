namespace SampleParser
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtContents = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(109, 48);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.ReadOnly = true;
            this.TxtFileName.Size = new System.Drawing.Size(301, 22);
            this.TxtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // TxtContents
            // 
            this.TxtContents.Location = new System.Drawing.Point(40, 95);
            this.TxtContents.Multiline = true;
            this.TxtContents.Name = "TxtContents";
            this.TxtContents.ReadOnly = true;
            this.TxtContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtContents.Size = new System.Drawing.Size(613, 252);
            this.TxtContents.TabIndex = 3;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(519, 48);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "&Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "PDFFile.pdf";
            this.dlgOpenFile.Filter = "PDF Files|*.pdf|All Files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 363);
            this.Controls.Add(this.TxtContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContents;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}

