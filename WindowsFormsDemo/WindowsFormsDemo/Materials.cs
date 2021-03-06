﻿using System;
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
    public partial class Materials : Form
    {
        LanguageChange languageChange = new LanguageChange();
        public Materials()
        {
            InitializeComponent();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            var obj = languageChange.start(lang);
            labelMaterials.Text = obj.resManage.GetString("Materials", obj.cultureInfo);
            labelSelectMaterialType.Text = obj.resManage.GetString("SelectMaterialType", obj.cultureInfo);
            labelSearch.Text = obj.resManage.GetString("Search", obj.cultureInfo);
        }
    }
}
