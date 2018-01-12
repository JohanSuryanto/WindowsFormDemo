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
    public partial class UserSettings : Form
    {
        private string[] textUiLang = { "English" , "Indonesia"};
        private string[] valueUiLang = { "en-US" , "id-ID" }; 
        private LanguageChange languageChange = new LanguageChange();

        public UserSettings()
        {
            InitializeComponent();
        }

        private void comboBoxUiLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxUiLanguage.Text;
            LangObject obj;

            switch (selected)
            {
                case "French":
                    Environment.SetEnvironmentVariable("lang", "fr-FR");
                    obj = languageChange.start("fr-FR");
                    break;
                case "Indonesia":
                    Environment.SetEnvironmentVariable("lang", "id-ID");
                    obj = languageChange.start("id-ID");
                    break;
                case "Chinese":
                    Environment.SetEnvironmentVariable("lang", "ii-CN");
                    obj = languageChange.start("ii-CN");
                    break;
                case "Japan":
                    Environment.SetEnvironmentVariable("lang", "ja-JP");
                    obj = languageChange.start("ja-JP");
                    break;
                default:
                    Environment.SetEnvironmentVariable("lang", "en-US");
                    obj = languageChange.start("en-US");
                    break;
            }
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < textUiLang.Count(); i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = textUiLang[i];
                item.Value = valueUiLang[i];
                comboBoxUiLanguage.Items.Add(item);
            }

            
            //int index = comboBoxUiLanguage.FindString((comboBoxUiLanguage.SelectedItem as ComboboxItem).Value.ToString());
            comboBoxUiLanguage.SelectedIndex = 0;
        }


        //object ComboboxItem 
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
    }
}
