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
    public partial class Maintenance : Form
    {
        private LanguageChange languageChange = new LanguageChange();
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            label1.Text = obj.resManage.GetString("Maintenance", obj.cultureInfo);
        }
    }
}
