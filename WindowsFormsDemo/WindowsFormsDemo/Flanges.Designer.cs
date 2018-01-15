namespace WindowsFormsDemo
{
    partial class Flanges
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
            this.labelProjectPreferences = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFlangeType = new System.Windows.Forms.Label();
            this.labelFlangeType2 = new System.Windows.Forms.Label();
            this.labelFlangeRating = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomSizeNPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OuterDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoltLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProjectPreferences
            // 
            this.labelProjectPreferences.AutoSize = true;
            this.labelProjectPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectPreferences.Location = new System.Drawing.Point(12, 170);
            this.labelProjectPreferences.Name = "labelProjectPreferences";
            this.labelProjectPreferences.Size = new System.Drawing.Size(126, 16);
            this.labelProjectPreferences.TabIndex = 0;
            this.labelProjectPreferences.Text = "Project Preferences";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 215);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "Code";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelFlangeType
            // 
            this.labelFlangeType.AutoSize = true;
            this.labelFlangeType.Location = new System.Drawing.Point(12, 250);
            this.labelFlangeType.Name = "labelFlangeType";
            this.labelFlangeType.Size = new System.Drawing.Size(66, 13);
            this.labelFlangeType.TabIndex = 3;
            this.labelFlangeType.Text = "Flange Type";
            // 
            // labelFlangeType2
            // 
            this.labelFlangeType2.AutoSize = true;
            this.labelFlangeType2.Location = new System.Drawing.Point(12, 284);
            this.labelFlangeType2.Name = "labelFlangeType2";
            this.labelFlangeType2.Size = new System.Drawing.Size(66, 13);
            this.labelFlangeType2.TabIndex = 4;
            this.labelFlangeType2.Text = "Flange Type";
            // 
            // labelFlangeRating
            // 
            this.labelFlangeRating.AutoSize = true;
            this.labelFlangeRating.Location = new System.Drawing.Point(12, 322);
            this.labelFlangeRating.Name = "labelFlangeRating";
            this.labelFlangeRating.Size = new System.Drawing.Size(73, 13);
            this.labelFlangeRating.TabIndex = 5;
            this.labelFlangeRating.Text = "Flange Rating";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(131, 247);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(131, 281);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(131, 319);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(15, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 167);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomSizeNPS,
            this.OuterDia,
            this.Thick,
            this.RFDia,
            this.ID,
            this.X,
            this.H,
            this.YY,
            this.BoltLength});
            this.dataGridView1.Location = new System.Drawing.Point(395, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 159);
            this.dataGridView1.TabIndex = 10;
            // 
            // NomSizeNPS
            // 
            this.NomSizeNPS.HeaderText = "Nom.Size(NPS)";
            this.NomSizeNPS.Name = "NomSizeNPS";
            // 
            // OuterDia
            // 
            this.OuterDia.HeaderText = "Outer Dia";
            this.OuterDia.Name = "OuterDia";
            // 
            // Thick
            // 
            this.Thick.HeaderText = "Thick";
            this.Thick.Name = "Thick";
            // 
            // RFDia
            // 
            this.RFDia.HeaderText = "RF Dia";
            this.RFDia.Name = "RFDia";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // YY
            // 
            this.YY.HeaderText = "YY";
            this.YY.Name = "YY";
            // 
            // BoltLength
            // 
            this.BoltLength.HeaderText = "Bolt Length";
            this.BoltLength.Name = "BoltLength";
            // 
            // Flanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelFlangeRating);
            this.Controls.Add(this.labelFlangeType2);
            this.Controls.Add(this.labelFlangeType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelProjectPreferences);
            this.Name = "Flanges";
            this.Text = "Flanges";
            this.Load += new System.EventHandler(this.Flanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectPreferences;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFlangeType;
        private System.Windows.Forms.Label labelFlangeType2;
        private System.Windows.Forms.Label labelFlangeRating;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSizeNPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OuterDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thick;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn YY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoltLength;
    }
}