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
    public partial class Actuation : Form
    {
        public Actuation()
        {
            InitializeComponent();
        }
        private void Actuation_Load(object sender, EventArgs e)
        {

        }
        public void setCultureInfo (string culture)
        {
            CultureInfo myCultureInfo = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = myCultureInfo;
            Thread.CurrentThread.CurrentUICulture = myCultureInfo;
            InitializeComponent();

            label37.Text = CommonResource.Description;
            label55.Text = "INFO" + myCultureInfo.EnglishName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLanguage newPopUP = new ChangeLanguage();
            newPopUP.Show();
        }
    }
}
