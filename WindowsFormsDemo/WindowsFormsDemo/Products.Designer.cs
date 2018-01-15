namespace WindowsFormsDemo
{
    partial class Products
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
            this.labelProductLiterature = new System.Windows.Forms.Label();
            this.labelSelectProductType = new System.Windows.Forms.Label();
            this.labelSelectProduct = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonBrochure = new System.Windows.Forms.Button();
            this.buttonInstallBase = new System.Windows.Forms.Button();
            this.buttonPresentations = new System.Windows.Forms.Button();
            this.buttonLeadTimes = new System.Windows.Forms.Button();
            this.buttonSuccessStories = new System.Windows.Forms.Button();
            this.buttonCompetiton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProductLiterature
            // 
            this.labelProductLiterature.AutoSize = true;
            this.labelProductLiterature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductLiterature.Location = new System.Drawing.Point(12, 157);
            this.labelProductLiterature.Name = "labelProductLiterature";
            this.labelProductLiterature.Size = new System.Drawing.Size(112, 16);
            this.labelProductLiterature.TabIndex = 0;
            this.labelProductLiterature.Text = "Product Literature";
            // 
            // labelSelectProductType
            // 
            this.labelSelectProductType.AutoSize = true;
            this.labelSelectProductType.Location = new System.Drawing.Point(12, 205);
            this.labelSelectProductType.Name = "labelSelectProductType";
            this.labelSelectProductType.Size = new System.Drawing.Size(116, 13);
            this.labelSelectProductType.TabIndex = 1;
            this.labelSelectProductType.Text = "Selected Product Type";
            // 
            // labelSelectProduct
            // 
            this.labelSelectProduct.AutoSize = true;
            this.labelSelectProduct.Location = new System.Drawing.Point(12, 230);
            this.labelSelectProduct.Name = "labelSelectProduct";
            this.labelSelectProduct.Size = new System.Drawing.Size(89, 13);
            this.labelSelectProduct.TabIndex = 2;
            this.labelSelectProduct.Text = "Selected Product";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 256);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User Selection",
            "User Selection",
            "User Selection"});
            this.comboBox1.Location = new System.Drawing.Point(134, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "User Selection";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "User Selection",
            "User Selection",
            "User Selection"});
            this.comboBox2.Location = new System.Drawing.Point(134, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "User Selection";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "User Input";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 282);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 190);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Summary of selected product. Includes size range, max/min capacity, max/min ratin" +
    "gs, available plug types, design and manufacturing locations, and technology own" +
    "er.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 202);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 270);
            this.textBox3.TabIndex = 8;
            // 
            // buttonBrochure
            // 
            this.buttonBrochure.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBrochure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrochure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBrochure.Location = new System.Drawing.Point(463, 202);
            this.buttonBrochure.Name = "buttonBrochure";
            this.buttonBrochure.Size = new System.Drawing.Size(149, 26);
            this.buttonBrochure.TabIndex = 9;
            this.buttonBrochure.Text = "Brochure";
            this.buttonBrochure.UseVisualStyleBackColor = false;
            // 
            // buttonInstallBase
            // 
            this.buttonInstallBase.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInstallBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInstallBase.Location = new System.Drawing.Point(463, 234);
            this.buttonInstallBase.Name = "buttonInstallBase";
            this.buttonInstallBase.Size = new System.Drawing.Size(149, 26);
            this.buttonInstallBase.TabIndex = 10;
            this.buttonInstallBase.Text = "Install Base";
            this.buttonInstallBase.UseVisualStyleBackColor = false;
            // 
            // buttonPresentations
            // 
            this.buttonPresentations.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPresentations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresentations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPresentations.Location = new System.Drawing.Point(463, 266);
            this.buttonPresentations.Name = "buttonPresentations";
            this.buttonPresentations.Size = new System.Drawing.Size(149, 26);
            this.buttonPresentations.TabIndex = 11;
            this.buttonPresentations.Text = "Presentations";
            this.buttonPresentations.UseVisualStyleBackColor = false;
            this.buttonPresentations.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonLeadTimes
            // 
            this.buttonLeadTimes.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLeadTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeadTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLeadTimes.Location = new System.Drawing.Point(463, 298);
            this.buttonLeadTimes.Name = "buttonLeadTimes";
            this.buttonLeadTimes.Size = new System.Drawing.Size(149, 26);
            this.buttonLeadTimes.TabIndex = 12;
            this.buttonLeadTimes.Text = "Lead Times";
            this.buttonLeadTimes.UseVisualStyleBackColor = false;
            // 
            // buttonSuccessStories
            // 
            this.buttonSuccessStories.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSuccessStories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuccessStories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSuccessStories.Location = new System.Drawing.Point(463, 330);
            this.buttonSuccessStories.Name = "buttonSuccessStories";
            this.buttonSuccessStories.Size = new System.Drawing.Size(149, 26);
            this.buttonSuccessStories.TabIndex = 13;
            this.buttonSuccessStories.Text = "Success Stories";
            this.buttonSuccessStories.UseVisualStyleBackColor = false;
            // 
            // buttonCompetiton
            // 
            this.buttonCompetiton.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCompetiton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompetiton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCompetiton.Location = new System.Drawing.Point(463, 362);
            this.buttonCompetiton.Name = "buttonCompetiton";
            this.buttonCompetiton.Size = new System.Drawing.Size(149, 26);
            this.buttonCompetiton.TabIndex = 14;
            this.buttonCompetiton.Text = "Competiton";
            this.buttonCompetiton.UseVisualStyleBackColor = false;
            this.buttonCompetiton.Click += new System.EventHandler(this.button6_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 514);
            this.Controls.Add(this.buttonCompetiton);
            this.Controls.Add(this.buttonSuccessStories);
            this.Controls.Add(this.buttonLeadTimes);
            this.Controls.Add(this.buttonPresentations);
            this.Controls.Add(this.buttonInstallBase);
            this.Controls.Add(this.buttonBrochure);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelSelectProduct);
            this.Controls.Add(this.labelSelectProductType);
            this.Controls.Add(this.labelProductLiterature);
            this.Name = "Products";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductLiterature;
        private System.Windows.Forms.Label labelSelectProductType;
        private System.Windows.Forms.Label labelSelectProduct;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonBrochure;
        private System.Windows.Forms.Button buttonInstallBase;
        private System.Windows.Forms.Button buttonPresentations;
        private System.Windows.Forms.Button buttonLeadTimes;
        private System.Windows.Forms.Button buttonSuccessStories;
        private System.Windows.Forms.Button buttonCompetiton;
    }
}