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
        private string[] textUiLang = { "English" , "Indonesia", "Chinese" };
        private string[] valueUiLang = { "en-US" , "id-ID" , "ii-CN" }; 
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
            this.ChangeLanguageNow();
        }

        private void ChangeLanguageNow()
        {
            var lang = Environment.GetEnvironmentVariable("lang");
            /* replace label text to language setting*/
            var obj = languageChange.start(lang);
            label1.Text = obj.resManage.GetString("UserPreferences", obj.cultureInfo);
            label2.Text = obj.resManage.GetString("ProductType", obj.cultureInfo);
            label13.Text = obj.resManage.GetString("Currency", obj.cultureInfo);
            label3.Text = obj.resManage.GetString("DateFormat", obj.cultureInfo);
            label4.Text = obj.resManage.GetString("OutputLanguage", obj.cultureInfo);
            label5.Text = obj.resManage.GetString("UILanguage", obj.cultureInfo);
            label6.Text = obj.resManage.GetString("SetDefaultPrintOption", obj.cultureInfo);
            label7.Text = obj.resManage.GetString("DisplaysProductsAttributes", obj.cultureInfo);
            label12.Text = obj.resManage.GetString("UserUnits", obj.cultureInfo);
            label14.Text = obj.resManage.GetString("UnitGroup", obj.cultureInfo);
            label11.Text = obj.resManage.GetString("MassFlow", obj.cultureInfo);
            label10.Text = obj.resManage.GetString("GasVolumeFlow", obj.cultureInfo);
            label9.Text = obj.resManage.GetString("LiquidVolumeFlow", obj.cultureInfo);
            label8.Text = obj.resManage.GetString("Length", obj.cultureInfo);
            label15.Text = obj.resManage.GetString("Area", obj.cultureInfo);
            label16.Text = obj.resManage.GetString("Distance", obj.cultureInfo);
            label17.Text = obj.resManage.GetString("Volume", obj.cultureInfo);
            label18.Text = obj.resManage.GetString("SpecificVolume", obj.cultureInfo);
            label19.Text = obj.resManage.GetString("Desity", obj.cultureInfo);
            label20.Text = obj.resManage.GetString("Viscocity", obj.cultureInfo);
            label30.Text = obj.resManage.GetString("ServicePressure", obj.cultureInfo);
            label29.Text = obj.resManage.GetString("DesignPressure", obj.cultureInfo);
            label28.Text = obj.resManage.GetString("Enthalpy", obj.cultureInfo);
            label27.Text = obj.resManage.GetString("Entholpy", obj.cultureInfo);
            label26.Text = obj.resManage.GetString("Velocity", obj.cultureInfo);
            label25.Text = obj.resManage.GetString("KineticEnergy", obj.cultureInfo);
            label24.Text = obj.resManage.GetString("Force", obj.cultureInfo);
            label23.Text = obj.resManage.GetString("SpringRate", obj.cultureInfo);
            label22.Text = obj.resManage.GetString("Stress", obj.cultureInfo);
            label21.Text = obj.resManage.GetString("SoundPower", obj.cultureInfo);
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            string findString = "";
            var lang = Environment.GetEnvironmentVariable("lang");
            for (int i = 0; i < textUiLang.Count(); i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = textUiLang[i];
                item.Value = valueUiLang[i];
                comboBoxUiLanguage.Items.Add(item);
                if(lang == valueUiLang[i])
                {
                    findString = textUiLang[i];
                }
            }


            int index = comboBoxUiLanguage.FindString(findString);
            comboBoxUiLanguage.SelectedIndex = index;

            this.ChangeLanguageNow();
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
