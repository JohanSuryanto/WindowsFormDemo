using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDemo.lang;

namespace WindowsFormsDemo
{
    public partial class Flanges : Form
    {
        LanguageChange languageChange = new LanguageChange();
        public Flanges()
        {
            InitializeComponent();
        }

        private void Flanges_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            labelProjectPreferences.Text = obj.resManage.GetString("ProjectPreferences", obj.cultureInfo);
            labelFlangeType.Text = obj.resManage.GetString("FlangeType", obj.cultureInfo);
            labelFlangeType2.Text = obj.resManage.GetString("FlangeType", obj.cultureInfo);
            labelFlangeRating.Text = obj.resManage.GetString("FlangeRating", obj.cultureInfo);
        }
    }
}
