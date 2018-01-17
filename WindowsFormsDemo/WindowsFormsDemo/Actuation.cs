using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using WindowsFormsDemo.lang;

namespace WindowsFormsDemo
{
    public partial class Actuation : Form
    {
        LanguageChange languageChange = new LanguageChange();

        public Actuation()
        {
            InitializeComponent();
        }
        private void Actuation_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("lang", "ii-CN");
            //Environment.SetEnvironmentVariable("lang", "id-ID");
            var lang = Environment.GetEnvironmentVariable("lang");
            /* replace label text to language setting*/
            var obj = languageChange.start(lang);
            LabelForceDefinition.Text = obj.resManage.GetString("ForceDefinition", obj.cultureInfo);
            LabelCoeff.Text = obj.resManage.GetString("CoeffOfFriction", obj.cultureInfo);
            LabelValvePlugSize.Text = obj.resManage.GetString("ValvePlugSize", obj.cultureInfo);
            LabelLeakageClass.Text = obj.resManage.GetString("LeakageClass", obj.cultureInfo);
            LabelStemOrientation.Text = obj.resManage.GetString("StemOrientation", obj.cultureInfo);
            LabelPlugDiameter.Text = obj.resManage.GetString("PlugDiameter", obj.cultureInfo);
            LabelMeanContact.Text = obj.resManage.GetString("MeanSeatContactDiameter", obj.cultureInfo);
            LabelValvePlugType.Text = obj.resManage.GetString("ValvePlugType", obj.cultureInfo);
            LabelMeanWidth.Text = obj.resManage.GetString("MeanSeatWidth", obj.cultureInfo);
            LabelPlugSeal.Text = obj.resManage.GetString("PlugSealDiameter", obj.cultureInfo);
            LabelStem.Text = obj.resManage.GetString("StemDiameter", obj.cultureInfo);
            LabelActual.Text = obj.resManage.GetString("ActualValueDiameter", obj.cultureInfo);
            LabelPlugDiam.Text = obj.resManage.GetString("PlugSealDiameter", obj.cultureInfo);
            LabelCoeff.Text = obj.resManage.GetString("CoeffOfFriction", obj.cultureInfo);
            LabelSeal.Text = obj.resManage.GetString("SealLenght", obj.cultureInfo);
            LabelPacking.Text = obj.resManage.GetString("PackingMaterial", obj.cultureInfo);
            LabelFric.Text = obj.resManage.GetString("CoeffOfFriction", obj.cultureInfo);
            LabelPack.Text = obj.resManage.GetString("PackingLenght", obj.cultureInfo);
            LabelPlugWeight.Text = obj.resManage.GetString("PlugWeight", obj.cultureInfo);
            LabelPressureOverPlug.Text = obj.resManage.GetString("PressureOverPlug", obj.cultureInfo);
            LabelPressureUnderPlug.Text = obj.resManage.GetString("PressureUnderPlug", obj.cultureInfo);
            LabelHydraulicRunning.Text = obj.resManage.GetString("HydraulicForceRunning", obj.cultureInfo);
            LabelHydraulicSeated.Text = obj.resManage.GetString("HydraulicForceSeated", obj.cultureInfo);

            LabelForceRunning.Text = obj.resManage.GetString("ForceToLiftRunning", obj.cultureInfo);
            LabelForceSeat.Text = obj.resManage.GetString("ForceToLiftFromSeat", obj.cultureInfo);
            LabelForceClose.Text = obj.resManage.GetString("ForceToCloseRunning", obj.cultureInfo);
            LabelForceCloseSeat.Text = obj.resManage.GetString("ForceToCloseOnSeat", obj.cultureInfo);
            LabelThrustSeat.Text = obj.resManage.GetString("ThrustRequiredToSeat", obj.cultureInfo);
            LabelRequiredPLI.Text = obj.resManage.GetString("RequiredSeatPLI", obj.cultureInfo);
            LabelCriticalForce.Text = obj.resManage.GetString("CriticalForces", obj.cultureInfo);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
