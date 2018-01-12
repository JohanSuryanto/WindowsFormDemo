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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        public void setCultureInfo(string culture)
        {
            CultureInfo myCultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            InitializeComponent();

            label2.Text = myCultureInfo.CompareInfo.Name;
            label37.Text = CommonResource.Description;
            label55.Text = "INFO" + myCultureInfo.EnglishName;
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sync home = new Sync();
            home.setCultureInfo(label2.Text);
            home.Show();
        }
    }
}
