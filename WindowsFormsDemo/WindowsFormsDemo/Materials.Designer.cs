﻿namespace WindowsFormsDemo
{
    partial class Materials
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
            this.labelMaterials = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSelectMaterialType = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxMaterialType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaterialGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASTMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASMEName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DINName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMSEName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTDegC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTDegC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoeffOfFriction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASMEGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterials.Location = new System.Drawing.Point(12, 172);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(63, 16);
            this.labelMaterials.TabIndex = 0;
            this.labelMaterials.Text = "Materials";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(127, 256);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(199, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelSelectMaterialType
            // 
            this.labelSelectMaterialType.AutoSize = true;
            this.labelSelectMaterialType.Location = new System.Drawing.Point(17, 229);
            this.labelSelectMaterialType.Name = "labelSelectMaterialType";
            this.labelSelectMaterialType.Size = new System.Drawing.Size(104, 13);
            this.labelSelectMaterialType.TabIndex = 2;
            this.labelSelectMaterialType.Text = "Select Material Type";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(17, 256);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search";
            // 
            // comboBoxMaterialType
            // 
            this.comboBoxMaterialType.FormattingEnabled = true;
            this.comboBoxMaterialType.Location = new System.Drawing.Point(127, 226);
            this.comboBoxMaterialType.Name = "comboBoxMaterialType";
            this.comboBoxMaterialType.Size = new System.Drawing.Size(199, 21);
            this.comboBoxMaterialType.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialGroup,
            this.Form,
            this.ASTMName,
            this.ASMEName,
            this.ENName,
            this.DINName,
            this.JMSEName,
            this.UNSName,
            this.MaterialNo,
            this.CommonName,
            this.MaxTDegC,
            this.MinTDegC,
            this.CoeffOfFriction,
            this.ASMEGroup,
            this.ENGroup});
            this.dataGridView1.Location = new System.Drawing.Point(20, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 410);
            this.dataGridView1.TabIndex = 5;
            // 
            // MaterialGroup
            // 
            this.MaterialGroup.HeaderText = "Material Group";
            this.MaterialGroup.Name = "MaterialGroup";
            // 
            // Form
            // 
            this.Form.HeaderText = "Form";
            this.Form.Name = "Form";
            // 
            // ASTMName
            // 
            this.ASTMName.HeaderText = "ASTM Name";
            this.ASTMName.Name = "ASTMName";
            // 
            // ASMEName
            // 
            this.ASMEName.HeaderText = "ASME Name";
            this.ASMEName.Name = "ASMEName";
            // 
            // ENName
            // 
            this.ENName.HeaderText = "EN Name";
            this.ENName.Name = "ENName";
            // 
            // DINName
            // 
            this.DINName.HeaderText = "DIN Name";
            this.DINName.Name = "DINName";
            // 
            // JMSEName
            // 
            this.JMSEName.HeaderText = "JMSE Name";
            this.JMSEName.Name = "JMSEName";
            // 
            // UNSName
            // 
            this.UNSName.HeaderText = "UNS Name";
            this.UNSName.Name = "UNSName";
            // 
            // MaterialNo
            // 
            this.MaterialNo.HeaderText = "Material No.";
            this.MaterialNo.Name = "MaterialNo";
            // 
            // CommonName
            // 
            this.CommonName.HeaderText = "Common Name";
            this.CommonName.Name = "CommonName";
            this.CommonName.Width = 120;
            // 
            // MaxTDegC
            // 
            this.MaxTDegC.HeaderText = "Max T (deg c)";
            this.MaxTDegC.Name = "MaxTDegC";
            // 
            // MinTDegC
            // 
            this.MinTDegC.HeaderText = "Min T (Deg C)";
            this.MinTDegC.Name = "MinTDegC";
            // 
            // CoeffOfFriction
            // 
            this.CoeffOfFriction.HeaderText = "Coeff of Friction";
            this.CoeffOfFriction.Name = "CoeffOfFriction";
            this.CoeffOfFriction.Width = 120;
            // 
            // ASMEGroup
            // 
            this.ASMEGroup.HeaderText = "ASME Group";
            this.ASMEGroup.Name = "ASMEGroup";
            // 
            // ENGroup
            // 
            this.ENGroup.HeaderText = "EN Group";
            this.ENGroup.Name = "ENGroup";
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 741);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxMaterialType);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSelectMaterialType);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelMaterials);
            this.Name = "Materials";
            this.Text = "Materials";
            this.Load += new System.EventHandler(this.Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSelectMaterialType;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxMaterialType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASTMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASMEName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DINName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMSEName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTDegC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTDegC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoeffOfFriction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASMEGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENGroup;
    }
}