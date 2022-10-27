namespace winforms_dateisumme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdCalculateSum = new System.Windows.Forms.Button();
            this.CmdDeletePostings = new System.Windows.Forms.Button();
            this.CmdChooseFile = new System.Windows.Forms.Button();
            this.cboFile = new System.Windows.Forms.ComboBox();
            this.LblFileHeadline = new System.Windows.Forms.Label();
            this.LblSumHeadline = new System.Windows.Forms.Label();
            this.LstDisplay = new System.Windows.Forms.ListView();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.RosyBrown;
            this.CmdClose.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdClose.ForeColor = System.Drawing.Color.Transparent;
            this.CmdClose.Location = new System.Drawing.Point(813, 474);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(82, 37);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdCalculateSum
            // 
            this.CmdCalculateSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdCalculateSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCalculateSum.Location = new System.Drawing.Point(610, 51);
            this.CmdCalculateSum.Name = "CmdCalculateSum";
            this.CmdCalculateSum.Size = new System.Drawing.Size(113, 34);
            this.CmdCalculateSum.TabIndex = 1;
            this.CmdCalculateSum.Text = "Berechne Summe";
            this.CmdCalculateSum.UseVisualStyleBackColor = true;
            this.CmdCalculateSum.Click += new System.EventHandler(this.CmdCalculateSum_Click);
            // 
            // CmdDeletePostings
            // 
            this.CmdDeletePostings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdDeletePostings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdDeletePostings.Location = new System.Drawing.Point(580, 123);
            this.CmdDeletePostings.Name = "CmdDeletePostings";
            this.CmdDeletePostings.Size = new System.Drawing.Size(143, 34);
            this.CmdDeletePostings.TabIndex = 2;
            this.CmdDeletePostings.Text = "Einträge löschen";
            this.CmdDeletePostings.UseVisualStyleBackColor = true;
            this.CmdDeletePostings.Click += new System.EventHandler(this.CmdDeletePostings_Click);
            // 
            // CmdChooseFile
            // 
            this.CmdChooseFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmdChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdChooseFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdChooseFile.Location = new System.Drawing.Point(466, 54);
            this.CmdChooseFile.Name = "CmdChooseFile";
            this.CmdChooseFile.Size = new System.Drawing.Size(37, 29);
            this.CmdChooseFile.TabIndex = 3;
            this.CmdChooseFile.Text = ". . .";
            this.CmdChooseFile.UseVisualStyleBackColor = false;
            this.CmdChooseFile.Click += new System.EventHandler(this.CmdChooseFile_Click);
            // 
            // cboFile
            // 
            this.cboFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFile.FormattingEnabled = true;
            this.cboFile.Location = new System.Drawing.Point(67, 54);
            this.cboFile.Name = "cboFile";
            this.cboFile.Size = new System.Drawing.Size(393, 33);
            this.cboFile.TabIndex = 5;
            // 
            // LblFileHeadline
            // 
            this.LblFileHeadline.AutoSize = true;
            this.LblFileHeadline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFileHeadline.Location = new System.Drawing.Point(67, 32);
            this.LblFileHeadline.Name = "LblFileHeadline";
            this.LblFileHeadline.Size = new System.Drawing.Size(41, 19);
            this.LblFileHeadline.TabIndex = 6;
            this.LblFileHeadline.Text = "Datei";
            this.LblFileHeadline.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSumHeadline
            // 
            this.LblSumHeadline.AutoSize = true;
            this.LblSumHeadline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSumHeadline.Location = new System.Drawing.Point(67, 104);
            this.LblSumHeadline.Name = "LblSumHeadline";
            this.LblSumHeadline.Size = new System.Drawing.Size(55, 19);
            this.LblSumHeadline.TabIndex = 7;
            this.LblSumHeadline.Text = "Summe";
            // 
            // LstDisplay
            // 
            this.LstDisplay.Location = new System.Drawing.Point(67, 195);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(656, 316);
            this.LstDisplay.TabIndex = 8;
            this.LstDisplay.UseCompatibleStateImageBehavior = false;
            this.LstDisplay.SelectedIndexChanged += new System.EventHandler(this.LstDisplay_SelectedIndexChanged);
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSum.Location = new System.Drawing.Point(67, 125);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(393, 32);
            this.txtSum.TabIndex = 9;
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.BackColor = System.Drawing.Color.White;
            this.LblDisplay.Location = new System.Drawing.Point(76, 208);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(0, 15);
            this.LblDisplay.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 530);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.LblSumHeadline);
            this.Controls.Add(this.LblFileHeadline);
            this.Controls.Add(this.cboFile);
            this.Controls.Add(this.CmdChooseFile);
            this.Controls.Add(this.CmdDeletePostings);
            this.Controls.Add(this.CmdCalculateSum);
            this.Controls.Add(this.CmdClose);
            this.Name = "Form1";
            this.Text = "Aufgabe 05: WindowsForms (DateiSumme)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdClose;
        private Button CmdCalculateSum;
        private Button CmdDeletePostings;
        private Button CmdChooseFile;
        private ComboBox cboFile;
        private Label LblFileHeadline;
        private Label LblSumHeadline;
        private ListView LstDisplay;
        private TextBox txtSum;
        private Label LblDisplay;
        private OpenFileDialog openFileDialog1;
    }
}