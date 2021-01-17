namespace WindowsFormsApp5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblGregDate = new System.Windows.Forms.Label();
            this.lblPersianDate = new System.Windows.Forms.Label();
            this.lblHijriDate = new System.Windows.Forms.Label();
            this.chkMakeAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkNoBorder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblGregDate
            // 
            this.lblGregDate.AutoSize = true;
            this.lblGregDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGregDate.Location = new System.Drawing.Point(12, 38);
            this.lblGregDate.Name = "lblGregDate";
            this.lblGregDate.Size = new System.Drawing.Size(24, 24);
            this.lblGregDate.TabIndex = 0;
            this.lblGregDate.Text = "--";
            // 
            // lblPersianDate
            // 
            this.lblPersianDate.AutoSize = true;
            this.lblPersianDate.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersianDate.Location = new System.Drawing.Point(12, 9);
            this.lblPersianDate.Name = "lblPersianDate";
            this.lblPersianDate.Size = new System.Drawing.Size(31, 29);
            this.lblPersianDate.TabIndex = 0;
            this.lblPersianDate.Text = "--";
            // 
            // lblHijriDate
            // 
            this.lblHijriDate.AutoSize = true;
            this.lblHijriDate.Location = new System.Drawing.Point(12, 68);
            this.lblHijriDate.Name = "lblHijriDate";
            this.lblHijriDate.Size = new System.Drawing.Size(22, 21);
            this.lblHijriDate.TabIndex = 0;
            this.lblHijriDate.Text = "--";
            // 
            // chkMakeAlwaysOnTop
            // 
            this.chkMakeAlwaysOnTop.AutoSize = true;
            this.chkMakeAlwaysOnTop.Location = new System.Drawing.Point(166, 41);
            this.chkMakeAlwaysOnTop.Name = "chkMakeAlwaysOnTop";
            this.chkMakeAlwaysOnTop.Size = new System.Drawing.Size(173, 25);
            this.chkMakeAlwaysOnTop.TabIndex = 1;
            this.chkMakeAlwaysOnTop.Text = "MakeAlwaysOnTop";
            this.chkMakeAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkMakeAlwaysOnTop.CheckedChanged += new System.EventHandler(this.ChkMakeAlwaysOnTop_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(161, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 29);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chkNoBorder
            // 
            this.chkNoBorder.AutoSize = true;
            this.chkNoBorder.Location = new System.Drawing.Point(166, 68);
            this.chkNoBorder.Name = "chkNoBorder";
            this.chkNoBorder.Size = new System.Drawing.Size(101, 25);
            this.chkNoBorder.TabIndex = 1;
            this.chkNoBorder.Text = "NoBorder";
            this.chkNoBorder.UseVisualStyleBackColor = true;
            this.chkNoBorder.CheckedChanged += new System.EventHandler(this.ChkNoBorder_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 96);
            this.Controls.Add(this.chkNoBorder);
            this.Controls.Add(this.chkMakeAlwaysOnTop);
            this.Controls.Add(this.lblHijriDate);
            this.Controls.Add(this.lblPersianDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblGregDate);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Current Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGregDate;
        private System.Windows.Forms.Label lblPersianDate;
        private System.Windows.Forms.Label lblHijriDate;
        private System.Windows.Forms.CheckBox chkMakeAlwaysOnTop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkNoBorder;
    }
}

