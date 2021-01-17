using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            updateTimes();
        }

        string getPerianDateString(DateTime dt)
        {
            var pc = new PersianCalendar();
            string result = "" + pc.GetYear(dt) + "-" + pc.GetMonth(dt).ToString("00") + "-" + pc.GetDayOfMonth(dt).ToString("00");
            return result;
        }

        string getHijriDateString(DateTime dt)
        {
            var pc = new HijriCalendar();
            pc.HijriAdjustment = -1;
            string result = "" + pc.GetYear(dt) + "-" + pc.GetMonth(dt).ToString("00") + "-" + pc.GetDayOfMonth(dt).ToString("00");
            return result;
        }

        private void ChkMakeAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkMakeAlwaysOnTop.Checked;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            updateTimes();

        }

        private void updateTimes()
        {
            DateTime now = DateTime.Now;
            lblGregDate.Text = now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
            lblPersianDate.Text = getPerianDateString(now);
            lblHijriDate.Text = getHijriDateString(now);
            lblTime.Text = now.ToString("T", DateTimeFormatInfo.InvariantInfo);
        }

        private void ChkNoBorder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoBorder.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }
}
