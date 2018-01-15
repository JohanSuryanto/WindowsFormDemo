namespace WindowsFormsDemo
{
    partial class Fluids
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
            this.labelFluids = new System.Windows.Forms.Label();
            this.labelSelectFluidType = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxFluidType = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Namez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValtekNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFluids
            // 
            this.labelFluids.AutoSize = true;
            this.labelFluids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFluids.Location = new System.Drawing.Point(13, 171);
            this.labelFluids.Name = "labelFluids";
            this.labelFluids.Size = new System.Drawing.Size(44, 16);
            this.labelFluids.TabIndex = 0;
            this.labelFluids.Text = "Fluids";
            // 
            // labelSelectFluidType
            // 
            this.labelSelectFluidType.AutoSize = true;
            this.labelSelectFluidType.Location = new System.Drawing.Point(15, 228);
            this.labelSelectFluidType.Name = "labelSelectFluidType";
            this.labelSelectFluidType.Size = new System.Drawing.Size(89, 13);
            this.labelSelectFluidType.TabIndex = 1;
            this.labelSelectFluidType.Text = "Select Fluid Type";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(15, 258);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search";
            // 
            // comboBoxFluidType
            // 
            this.comboBoxFluidType.FormattingEnabled = true;
            this.comboBoxFluidType.Location = new System.Drawing.Point(110, 228);
            this.comboBoxFluidType.Name = "comboBoxFluidType";
            this.comboBoxFluidType.Size = new System.Drawing.Size(205, 21);
            this.comboBoxFluidType.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(62, 255);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(253, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namez,
            this.Formula,
            this.MW,
            this.ValtekNo,
            this.Tck,
            this.k,
            this.LowerK,
            this.UpperK});
            this.dataGridView1.Location = new System.Drawing.Point(18, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 403);
            this.dataGridView1.TabIndex = 5;
            // 
            // Namez
            // 
            this.Namez.HeaderText = "Name";
            this.Namez.Name = "Namez";
            // 
            // Formula
            // 
            this.Formula.HeaderText = "Formula";
            this.Formula.Name = "Formula";
            // 
            // MW
            // 
            this.MW.HeaderText = "MW";
            this.MW.Name = "MW";
            // 
            // ValtekNo
            // 
            this.ValtekNo.HeaderText = "Valtek.No";
            this.ValtekNo.Name = "ValtekNo";
            // 
            // Tck
            // 
            this.Tck.HeaderText = "Tc (K)";
            this.Tck.Name = "Tck";
            // 
            // k
            // 
            this.k.HeaderText = "k";
            this.k.Name = "k";
            // 
            // LowerK
            // 
            this.LowerK.HeaderText = "Lower (K)";
            this.LowerK.Name = "LowerK";
            // 
            // UpperK
            // 
            this.UpperK.HeaderText = "Upper (K)";
            this.UpperK.Name = "UpperK";
            // 
            // Fluids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 741);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxFluidType);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSelectFluidType);
            this.Controls.Add(this.labelFluids);
            this.Name = "Fluids";
            this.Text = "Fluids";
            this.Load += new System.EventHandler(this.Fluids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFluids;
        private System.Windows.Forms.Label labelSelectFluidType;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxFluidType;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn MW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValtekNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tck;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerK;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperK;
    }
}