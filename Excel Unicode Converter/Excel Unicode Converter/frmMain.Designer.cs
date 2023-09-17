namespace Excel_Unicode_Converter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.optNoIncrease = new System.Windows.Forms.RadioButton();
            this.optIncrease = new System.Windows.Forms.RadioButton();
            this.optDecrease = new System.Windows.Forms.RadioButton();
            this.nudIncrease = new System.Windows.Forms.NumericUpDown();
            this.lblIncrease = new System.Windows.Forms.Label();
            this.lblDecrease = new System.Windows.Forms.Label();
            this.nudDecrease = new System.Windows.Forms.NumericUpDown();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecrease)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(23, 25);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(63, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source File:";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtSource.Location = new System.Drawing.Point(92, 21);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(522, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.TabStop = false;
            this.txtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(631, 18);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(79, 27);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(631, 55);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(79, 27);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save As";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtNewFile
            // 
            this.txtNewFile.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtNewFile.Location = new System.Drawing.Point(92, 58);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.ReadOnly = true;
            this.txtNewFile.Size = new System.Drawing.Size(522, 20);
            this.txtNewFile.TabIndex = 4;
            this.txtNewFile.TabStop = false;
            this.txtNewFile.TextChanged += new System.EventHandler(this.TxtNewFile_TextChanged);
            // 
            // lblNewFile
            // 
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Location = new System.Drawing.Point(35, 62);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(51, 13);
            this.lblNewFile.TabIndex = 3;
            this.lblNewFile.Text = "New File:";
            // 
            // optNoIncrease
            // 
            this.optNoIncrease.AutoSize = true;
            this.optNoIncrease.Location = new System.Drawing.Point(92, 104);
            this.optNoIncrease.Name = "optNoIncrease";
            this.optNoIncrease.Size = new System.Drawing.Size(121, 17);
            this.optNoIncrease.TabIndex = 3;
            this.optNoIncrease.TabStop = true;
            this.optNoIncrease.Text = "Do not increase font";
            this.optNoIncrease.UseVisualStyleBackColor = true;
            this.optNoIncrease.CheckedChanged += new System.EventHandler(this.OptNoIncrease_CheckedChanged);
            // 
            // optIncrease
            // 
            this.optIncrease.AutoSize = true;
            this.optIncrease.Location = new System.Drawing.Point(92, 137);
            this.optIncrease.Name = "optIncrease";
            this.optIncrease.Size = new System.Drawing.Size(87, 17);
            this.optIncrease.TabIndex = 4;
            this.optIncrease.TabStop = true;
            this.optIncrease.Text = "Increase font";
            this.optIncrease.UseVisualStyleBackColor = true;
            this.optIncrease.CheckedChanged += new System.EventHandler(this.OptIncrease_CheckedChanged);
            // 
            // optDecrease
            // 
            this.optDecrease.AutoSize = true;
            this.optDecrease.Location = new System.Drawing.Point(92, 172);
            this.optDecrease.Name = "optDecrease";
            this.optDecrease.Size = new System.Drawing.Size(92, 17);
            this.optDecrease.TabIndex = 6;
            this.optDecrease.TabStop = true;
            this.optDecrease.Text = "Decrease font";
            this.optDecrease.UseVisualStyleBackColor = true;
            this.optDecrease.CheckedChanged += new System.EventHandler(this.OptDecrease_CheckedChanged);
            // 
            // nudIncrease
            // 
            this.nudIncrease.Location = new System.Drawing.Point(185, 135);
            this.nudIncrease.Name = "nudIncrease";
            this.nudIncrease.Size = new System.Drawing.Size(44, 20);
            this.nudIncrease.TabIndex = 5;
            this.nudIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIncrease
            // 
            this.lblIncrease.AutoSize = true;
            this.lblIncrease.Location = new System.Drawing.Point(235, 139);
            this.lblIncrease.Name = "lblIncrease";
            this.lblIncrease.Size = new System.Drawing.Size(35, 13);
            this.lblIncrease.TabIndex = 10;
            this.lblIncrease.Text = "points";
            // 
            // lblDecrease
            // 
            this.lblDecrease.AutoSize = true;
            this.lblDecrease.Location = new System.Drawing.Point(235, 174);
            this.lblDecrease.Name = "lblDecrease";
            this.lblDecrease.Size = new System.Drawing.Size(35, 13);
            this.lblDecrease.TabIndex = 12;
            this.lblDecrease.Text = "points";
            // 
            // nudDecrease
            // 
            this.nudDecrease.Location = new System.Drawing.Point(185, 170);
            this.nudDecrease.Name = "nudDecrease";
            this.nudDecrease.Size = new System.Drawing.Size(44, 20);
            this.nudDecrease.TabIndex = 7;
            this.nudDecrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(631, 172);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(79, 27);
            this.cmdConvert.TabIndex = 8;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.CmdConvert_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdClose.Location = new System.Drawing.Point(631, 219);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(79, 27);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 270);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.lblDecrease);
            this.Controls.Add(this.nudDecrease);
            this.Controls.Add(this.lblIncrease);
            this.Controls.Add(this.nudIncrease);
            this.Controls.Add(this.optDecrease);
            this.Controls.Add(this.optIncrease);
            this.Controls.Add(this.optNoIncrease);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.lblNewFile);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Unicode Converter";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecrease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtNewFile;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.RadioButton optNoIncrease;
        private System.Windows.Forms.RadioButton optIncrease;
        private System.Windows.Forms.RadioButton optDecrease;
        private System.Windows.Forms.NumericUpDown nudIncrease;
        private System.Windows.Forms.Label lblIncrease;
        private System.Windows.Forms.Label lblDecrease;
        private System.Windows.Forms.NumericUpDown nudDecrease;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Button cmdClose;
    }
}

