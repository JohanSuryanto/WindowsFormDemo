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
    public partial class Products : Form
    {
        LanguageChange languageChange = new LanguageChange();
        public Products()
        {
            InitializeComponent();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);

            /* Change to default Language */
            labelProductLiterature.Text = obj.resManage.GetString("ProductLiterature", obj.cultureInfo);
            labelSelectProduct.Text = obj.resManage.GetString("SelectProduct", obj.cultureInfo);
            labelSelectProductType.Text = obj.resManage.GetString("SelectProductType", obj.cultureInfo);
            labelSearch.Text = obj.resManage.GetString("Search", obj.cultureInfo);
            
            buttonBrochure.Text = obj.resManage.GetString("Brochure", obj.cultureInfo);
            buttonInstallBase.Text = obj.resManage.GetString("InstallBase", obj.cultureInfo);
            buttonPresentations.Text = obj.resManage.GetString("Presentations", obj.cultureInfo);
            buttonLeadTimes.Text = obj.resManage.GetString("LeadTimes", obj.cultureInfo);
            buttonSuccessStories.Text = obj.resManage.GetString("SuccessStories", obj.cultureInfo);
            buttonCompetiton.Text = obj.resManage.GetString("Competiton", obj.cultureInfo);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
