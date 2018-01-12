using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class ChangeLanguage : Form
    {
        public ChangeLanguage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string language = languageComboBox.SelectedItem.ToString();
            string cultureInfo;
            switch (language)
            {
                case "Indonesia":
                    cultureInfo = "id-ID";
                    break;
                default:
                    cultureInfo = "en-US";
                    break;
            }
            Layout setLay = new Layout();
            Update setUp = new Update();
            setUp.setCultureInfo(cultureInfo);
            setUp.Show();
        }
    }
}
