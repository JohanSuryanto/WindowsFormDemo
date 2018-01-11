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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fluids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Fluid Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fluids";
            this.Text = "Fluids";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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