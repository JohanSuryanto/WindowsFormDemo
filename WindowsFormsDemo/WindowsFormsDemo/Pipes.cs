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
    public partial class Pipes : Form
    {
        LanguageChange languageChange = new LanguageChange();

        public Pipes()
        {
            InitializeComponent();
        }

        private void Pipes_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            labelPipes.Text = obj.resManage.GetString("Pipes", obj.cultureInfo);
            labelSelectPipeCategory.Text = obj.resManage.GetString("SelectPipeCategory", obj.cultureInfo);
            labelSearch.Text = obj.resManage.GetString("Search", obj.cultureInfo);
        }
    }
}
