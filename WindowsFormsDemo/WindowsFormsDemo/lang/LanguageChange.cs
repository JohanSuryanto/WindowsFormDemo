using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace WindowsFormsDemo.lang
{
    class LanguageChange
    {
        public LangObject start(string region)
        {
            //create LangObject Instien use to return this method
            LangObject obj = new LangObject();

            //generate the language by parameter region
            CultureInfo ci = new CultureInfo(region);
            Assembly a = Assembly.Load("WindowsFormsDemo");
            ResourceManager rm = new ResourceManager("WindowsFormsDemo.lang.lang", a);

            //set obj property from insten LangObject 
            obj.cultureInfo = ci;
            obj.resManage = rm;

            return obj;
        }
    }

    public class LangObject
    {
        public CultureInfo cultureInfo { get; set; }
        public ResourceManager resManage { get; set; }
    }
}
