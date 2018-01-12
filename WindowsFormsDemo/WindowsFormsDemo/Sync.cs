using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace WindowsFormsDemo
{
    public partial class Sync : Form
    {
        public Sync()
        {
            InitializeComponent();
        }
        public void setCultureInfo(string culture)
        {
            CultureInfo myCultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            InitializeComponent();

            //label2.Text = myCultureInfo.CompareInfo.Name;
            label37.Text = CommonResource.Description;
            label55.Text = "INFO" + myCultureInfo.EnglishName;
        }
        private void Sync_Load(object sender, EventArgs e)
        {

        }
    }
}
