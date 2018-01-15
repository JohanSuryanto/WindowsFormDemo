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
    public partial class Fluids : Form
    {

        LanguageChange languageChange = new LanguageChange();
        public Fluids()
        {
            InitializeComponent();
        }

        private void Fluids_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            labelFluids.Text = obj.resManage.GetString("Fluids", obj.cultureInfo);
            labelSearch.Text = obj.resManage.GetString("Search", obj.cultureInfo);
            labelSelectFluidType.Text = obj.resManage.GetString("SelectFluidType", obj.cultureInfo);
        }
    }
}
