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
    public partial class Conditions : Form
    {
        LanguageChange languageChange = new LanguageChange();
        public Conditions()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Conditions_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("lang", "ii-CN");

            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);

            //labelSelectConditions.Text = obj.resManage.GetString("SelectConditions", obj.cultureInfo);
            //labelDescription.Text = obj.resManage.GetString("Description", obj.cultureInfo);
            LabelInletFlowRate.Text = obj.resManage.GetString("InletFlowRate", obj.cultureInfo);
            LabelInletPressure.Text = obj.resManage.GetString("InletPressure", obj.cultureInfo);
            LabelInletTemperature.Text = obj.resManage.GetString("InletTemperature", obj.cultureInfo);
            LabelInletEnthalpy.Text = obj.resManage.GetString("InletEnthalpy", obj.cultureInfo);
            LabelInletDensity.Text = obj.resManage.GetString("InletDensity", obj.cultureInfo);
            LabelPressureDifferential.Text = obj.resManage.GetString("PressureDifferential", obj.cultureInfo);

            LabelInletFlowRateFlow.Text = obj.resManage.GetString("InletFlowRate", obj.cultureInfo);
            LabelInletPressureFlow.Text = obj.resManage.GetString("InletPressure", obj.cultureInfo);
            LabelInletTemperatureFlow.Text = obj.resManage.GetString("InletTemperature", obj.cultureInfo);
            LabelInletEnthalpyFlow.Text = obj.resManage.GetString("InletEnthalpy", obj.cultureInfo);
            LabelInletDesityFlow.Text = obj.resManage.GetString("InletDensity", obj.cultureInfo);
            LabelPressureDifferentialFlow.Text = obj.resManage.GetString("PressureDifferential", obj.cultureInfo);
            
            LabelInletFlowRateBlock.Text = obj.resManage.GetString("InletFlowRate", obj.cultureInfo);
            LabelInletPressureBlock.Text = obj.resManage.GetString("InletPressure", obj.cultureInfo);
            LabelInletTemperatureBlock.Text = obj.resManage.GetString("InletTemperature", obj.cultureInfo);
            LabelInletEnthalpyBlock.Text = obj.resManage.GetString("InletEnthalpy", obj.cultureInfo);
            LabelInletDensityBlock.Text = obj.resManage.GetString("InletDensity", obj.cultureInfo);
            LabelPressureDifferentialBlock.Text = obj.resManage.GetString("PressureDifferential", obj.cultureInfo);
        }
    }
}
