namespace SumOfNumbersAllisonC
{
    partial class frmSumOfNumbers
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstnumbers = new System.Windows.Forms.ListBox();
            this.lblenter = new System.Windows.Forms.Label();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Adobe Song Std L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(97, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstnumbers
            // 
            this.lstnumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstnumbers.FormattingEnabled = true;
            this.lstnumbers.ItemHeight = 20;
            this.lstnumbers.Location = new System.Drawing.Point(71, 124);
            this.lstnumbers.Name = "lstnumbers";
            this.lstnumbers.Size = new System.Drawing.Size(121, 104);
            this.lstnumbers.TabIndex = 1;
            // 
            // lblenter
            // 
            this.lblenter.AutoSize = true;
            this.lblenter.Font = new System.Drawing.Font("Adobe Song Std L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenter.Location = new System.Drawing.Point(36, 53);
            this.lblenter.Name = "lblenter";
            this.lblenter.Size = new System.Drawing.Size(112, 19);
            this.lblenter.TabIndex = 2;
            this.lblenter.Text = "Enter a Number:";
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(154, 55);
            this.numNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(63, 20);
            this.numNumber.TabIndex = 3;
            this.numNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(284, 24);
            this.mnuMenu.TabIndex = 4;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Adobe Song Std L", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(36, 233);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 19);
            this.lblAnswer.TabIndex = 5;
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.lblenter);
            this.Controls.Add(this.lstnumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum of Numbers by Allison C";
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstnumbers;
        private System.Windows.Forms.Label lblenter;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblAnswer;
    }
}

