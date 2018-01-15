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
    public partial class Calculators : Form
    {
        private LanguageChange languageChange = new LanguageChange();
        public Calculators()
        {
            InitializeComponent();
        }

        private void Calculators_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            buttonActuators.Text = obj.resManage.GetString("Actuator", obj.cultureInfo);
            buttonDesuperheating.Text = obj.resManage.GetString("Desuperheating", obj.cultureInfo);
            buttonFavorites.Text = obj.resManage.GetString("Favorites", obj.cultureInfo);
            buttonFluids.Text = obj.resManage.GetString("Fluids", obj.cultureInfo);
            buttonGeneral.Text = obj.resManage.GetString("General", obj.cultureInfo);
            buttonValveDesing.Text = obj.resManage.GetString("ValveDesing", obj.cultureInfo);
            labelFavorite.Text = obj.resManage.GetString("Favorites", obj.cultureInfo);
            labelSearch.Text = obj.resManage.GetString("Search", obj.cultureInfo);
            labelSeatLeak.Text = obj.resManage.GetString("SeatLeakage", obj.cultureInfo);
            labelCalculator.Text = obj.resManage.GetString("Calculator", obj.cultureInfo);
        }
    }
}
