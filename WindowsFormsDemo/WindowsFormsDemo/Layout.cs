﻿using System;
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
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabProject_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lang = Environment.GetEnvironmentVariable("lang");
            if (lang == null)
            {
                Environment.SetEnvironmentVariable("lang", "en-US");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

        }

        private void buttonLink_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUserSetting_Click(object sender, EventArgs e)
        {
            UserSettings page = new UserSettings();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonCaculator_Click(object sender, EventArgs e)
        {
            Calculators page = new Calculators();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonFluids_Click(object sender, EventArgs e)
        {
            Fluids page = new Fluids();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            Materials page = new Materials();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Products page = new Products();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            Company page = new Company();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonFlanges_Click(object sender, EventArgs e)
        {
            Flanges page = new Flanges();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonPipes_Click(object sender, EventArgs e)
        {
            Pipes page = new Pipes();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Update page = new Update();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            Sync page = new Sync();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void buttonMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance page = new Maintenance();
            page.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(page);
            page.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            page.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
