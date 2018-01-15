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
    public partial class Sync : Form
    {
        LanguageChange languageChange = new LanguageChange();
        public Sync()
        {
            InitializeComponent();
        }

        private void Sync_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);

            /* Change to default Language */
            label1.Text = obj.resManage.GetString("Sync", obj.cultureInfo);
        }
    }
}
