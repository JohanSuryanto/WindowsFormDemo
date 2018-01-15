namespace WindowsFormsDemo
{
    partial class Pipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPipes = new System.Windows.Forms.Label();
            this.labelSelectPipeCategory = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thickmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thickin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPipes
            // 
            this.labelPipes.AutoSize = true;
            this.labelPipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPipes.Location = new System.Drawing.Point(8, 170);
            this.labelPipes.Name = "labelPipes";
            this.labelPipes.Size = new System.Drawing.Size(43, 16);
            this.labelPipes.TabIndex = 0;
            this.labelPipes.Text = "Pipes";
            // 
            // labelSelectPipeCategory
            // 
            this.labelSelectPipeCategory.AutoSize = true;
            this.labelSelectPipeCategory.Location = new System.Drawing.Point(8, 215);
            this.labelSelectPipeCategory.Name = "labelSelectPipeCategory";
            this.labelSelectPipeCategory.Size = new System.Drawing.Size(106, 13);
            this.labelSelectPipeCategory.TabIndex = 1;
            this.labelSelectPipeCategory.Text = "Select Pipe Category";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(8, 245);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NPS",
            "API"});
            this.comboBox1.Location = new System.Drawing.Point(120, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "NPS or API";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "User Input";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cat,
            this.nps,
            this.dn,
            this.Sch,
            this.od,
            this.odin,
            this.idmm,
            this.idin,
            this.thickmm,
            this.thickin});
            this.dataGridView1.Location = new System.Drawing.Point(8, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 358);
            this.dataGridView1.TabIndex = 5;
            // 
            // cat
            // 
            this.cat.HeaderText = "Category";
            this.cat.Name = "cat";
            // 
            // nps
            // 
            this.nps.HeaderText = "Nom. Size (NPS)";
            this.nps.Name = "nps";
            // 
            // dn
            // 
            this.dn.HeaderText = "Nom. Size (DN)";
            this.dn.Name = "dn";
            // 
            // Sch
            // 
            this.Sch.HeaderText = "Schedule";
            this.Sch.Name = "Sch";
            // 
            // od
            // 
            this.od.HeaderText = "OD (mm)";
            this.od.Name = "od";
            // 
            // odin
            // 
            this.odin.HeaderText = "OD (in.)";
            this.odin.Name = "odin";
            // 
            // idmm
            // 
            this.idmm.HeaderText = "ID (mm.)";
            this.idmm.Name = "idmm";
            // 
            // idin
            // 
            this.idin.HeaderText = "ID (in.)";
            this.idin.Name = "idin";
            // 
            // thickmm
            // 
            this.thickmm.HeaderText = "Thick (mm.)";
            this.thickmm.Name = "thickmm";
            // 
            // thickin
            // 
            this.thickin.HeaderText = "Thick (in.)";
            this.thickin.Name = "thickin";
            // 
            // Pipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 741);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSelectPipeCategory);
            this.Controls.Add(this.labelPipes);
            this.Name = "Pipes";
            this.Text = "Pipes";
            this.Load += new System.EventHandler(this.Pipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPipes;
        private System.Windows.Forms.Label labelSelectPipeCategory;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn od;
        private System.Windows.Forms.DataGridViewTextBoxColumn odin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idin;
        private System.Windows.Forms.DataGridViewTextBoxColumn thickmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn thickin;
    }
}