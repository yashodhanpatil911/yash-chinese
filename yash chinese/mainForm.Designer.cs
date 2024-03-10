namespace yash_chinese
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.namelabel = new System.Windows.Forms.Label();
            this.customernametextbox = new System.Windows.Forms.TextBox();
            this.customernamelabel = new System.Windows.Forms.Label();
            this.totalproductpricetextbox = new System.Windows.Forms.TextBox();
            this.productlabel = new System.Windows.Forms.Label();
            this.productnamecombobox = new System.Windows.Forms.ComboBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.quantitycombobox = new System.Windows.Forms.ComboBox();
            this.pricelabel = new System.Windows.Forms.Label();
            this.totalpricelabel = new System.Windows.Forms.Label();
            this.customernumbertextbox = new System.Windows.Forms.TextBox();
            this.printpreviewbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.pricetextbox1 = new System.Windows.Forms.TextBox();
            this.printDocumentbilldetail1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogbill = new System.Windows.Forms.PrintPreviewDialog();
            this.printbutton = new System.Windows.Forms.Button();
            this.addnewcustomerbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(48, 186);
            this.namelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.namelabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(119, 36);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "customer Name:";
            this.namelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // customernametextbox
            // 
            this.customernametextbox.AcceptsReturn = true;
            this.customernametextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customernametextbox.Location = new System.Drawing.Point(215, 188);
            this.customernametextbox.Name = "customernametextbox";
            this.customernametextbox.Size = new System.Drawing.Size(224, 24);
            this.customernametextbox.TabIndex = 0;
            this.customernametextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // customernamelabel
            // 
            this.customernamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customernamelabel.AutoSize = true;
            this.customernamelabel.Location = new System.Drawing.Point(23, 224);
            this.customernamelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.customernamelabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.customernamelabel.Name = "customernamelabel";
            this.customernamelabel.Size = new System.Drawing.Size(144, 36);
            this.customernamelabel.TabIndex = 0;
            this.customernamelabel.Text = "customer mobile no:";
            this.customernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalproductpricetextbox
            // 
            this.totalproductpricetextbox.Location = new System.Drawing.Point(215, 374);
            this.totalproductpricetextbox.Name = "totalproductpricetextbox";
            this.totalproductpricetextbox.ReadOnly = true;
            this.totalproductpricetextbox.Size = new System.Drawing.Size(224, 24);
            this.totalproductpricetextbox.TabIndex = 6;
            // 
            // productlabel
            // 
            this.productlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productlabel.AutoSize = true;
            this.productlabel.Location = new System.Drawing.Point(103, 262);
            this.productlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productlabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(64, 36);
            this.productlabel.TabIndex = 0;
            this.productlabel.Text = "Product:";
            this.productlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // productnamecombobox
            // 
            this.productnamecombobox.AllowDrop = true;
            this.productnamecombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Egg Full Rice",
            "Egg Half Rice",
            "Chiken Chillie Full",
            "Chiken Chillie HALF"});
            this.productnamecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnamecombobox.FormattingEnabled = true;
            this.productnamecombobox.Items.AddRange(new object[] {
            "rice",
            "loli pop",
            "chiken",
            "fried rice",
            "Egg Full Rice,",
            "Egg Half Rice,",
            "Chiken Chillie Full,",
            "Chiken Chillie HALF,"});
            this.productnamecombobox.Location = new System.Drawing.Point(215, 260);
            this.productnamecombobox.Name = "productnamecombobox";
            this.productnamecombobox.Size = new System.Drawing.Size(224, 26);
            this.productnamecombobox.TabIndex = 3;
            this.productnamecombobox.SelectedIndexChanged += new System.EventHandler(this.productname_SelectedIndexChanged);
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(101, 300);
            this.quantitylabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.quantitylabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(66, 36);
            this.quantitylabel.TabIndex = 0;
            this.quantitylabel.Text = "Quantity:";
            this.quantitylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantitycombobox
            // 
            this.quantitycombobox.AllowDrop = true;
            this.quantitycombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20"});
            this.quantitycombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitycombobox.FormattingEnabled = true;
            this.quantitycombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.quantitycombobox.Location = new System.Drawing.Point(215, 298);
            this.quantitycombobox.Name = "quantitycombobox";
            this.quantitycombobox.Size = new System.Drawing.Size(224, 26);
            this.quantitycombobox.TabIndex = 4;
            this.quantitycombobox.TextChanged += new System.EventHandler(this.quantitycombobox_TextChanged);
            // 
            // pricelabel
            // 
            this.pricelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(123, 338);
            this.pricelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pricelabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(44, 36);
            this.pricelabel.TabIndex = 0;
            this.pricelabel.Text = "price:";
            this.pricelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalpricelabel
            // 
            this.totalpricelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalpricelabel.AutoSize = true;
            this.totalpricelabel.Location = new System.Drawing.Point(42, 376);
            this.totalpricelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalpricelabel.MinimumSize = new System.Drawing.Size(38, 36);
            this.totalpricelabel.Name = "totalpricelabel";
            this.totalpricelabel.Size = new System.Drawing.Size(125, 36);
            this.totalpricelabel.TabIndex = 0;
            this.totalpricelabel.Text = "Total price to pay:";
            this.totalpricelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // customernumbertextbox
            // 
            this.customernumbertextbox.AcceptsReturn = true;
            this.customernumbertextbox.BackColor = System.Drawing.SystemColors.Window;
            this.customernumbertextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customernumbertextbox.Location = new System.Drawing.Point(218, 222);
            this.customernumbertextbox.Name = "customernumbertextbox";
            this.customernumbertextbox.Size = new System.Drawing.Size(224, 24);
            this.customernumbertextbox.TabIndex = 1;
            this.customernumbertextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // printpreviewbutton
            // 
            this.printpreviewbutton.BackColor = System.Drawing.Color.Crimson;
            this.printpreviewbutton.ForeColor = System.Drawing.Color.Black;
            this.printpreviewbutton.Location = new System.Drawing.Point(475, 326);
            this.printpreviewbutton.Name = "printpreviewbutton";
            this.printpreviewbutton.Size = new System.Drawing.Size(101, 43);
            this.printpreviewbutton.TabIndex = 9;
            this.printpreviewbutton.Text = "print preview";
            this.printpreviewbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.printpreviewbutton.UseVisualStyleBackColor = false;
            this.printpreviewbutton.Click += new System.EventHandler(this.savepdfbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.exitbutton.Location = new System.Drawing.Point(475, 374);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(101, 43);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exit_Click);
            // 
            // pricetextbox1
            // 
            this.pricetextbox1.AcceptsReturn = true;
            this.pricetextbox1.AcceptsTab = true;
            this.pricetextbox1.AllowDrop = true;
            this.pricetextbox1.BackColor = System.Drawing.SystemColors.Window;
            this.pricetextbox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pricetextbox1.Location = new System.Drawing.Point(215, 335);
            this.pricetextbox1.Name = "pricetextbox1";
            this.pricetextbox1.Size = new System.Drawing.Size(224, 24);
            this.pricetextbox1.TabIndex = 6;
            this.pricetextbox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // printDocumentbilldetail1
            // 
            this.printDocumentbilldetail1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentbilldetail1_PrintPage);
            // 
            // printPreviewDialogbill
            // 
            this.printPreviewDialogbill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogbill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogbill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogbill.Enabled = true;
            this.printPreviewDialogbill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogbill.Icon")));
            this.printPreviewDialogbill.Name = "printPreviewDialogbill";
            this.printPreviewDialogbill.Visible = false;
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.printbutton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.printbutton.Image = global::yash_chinese.Properties.Resources.printer;
            this.printbutton.Location = new System.Drawing.Point(475, 248);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(101, 73);
            this.printbutton.TabIndex = 8;
            this.printbutton.Text = "print bill";
            this.printbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // addnewcustomerbutton
            // 
            this.addnewcustomerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addnewcustomerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewcustomerbutton.Image = global::yash_chinese.Properties.Resources.add_user;
            this.addnewcustomerbutton.Location = new System.Drawing.Point(475, 189);
            this.addnewcustomerbutton.Name = "addnewcustomerbutton";
            this.addnewcustomerbutton.Size = new System.Drawing.Size(101, 54);
            this.addnewcustomerbutton.TabIndex = 7;
            this.addnewcustomerbutton.Text = "new customer";
            this.addnewcustomerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addnewcustomerbutton.UseCompatibleTextRendering = true;
            this.addnewcustomerbutton.UseMnemonic = false;
            this.addnewcustomerbutton.UseVisualStyleBackColor = false;
            this.addnewcustomerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::yash_chinese.Properties.Resources.android;
            this.pictureBox1.Location = new System.Drawing.Point(190, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(580, 553);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.printpreviewbutton);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.addnewcustomerbutton);
            this.Controls.Add(this.productnamecombobox);
            this.Controls.Add(this.totalpricelabel);
            this.Controls.Add(this.quantitycombobox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.totalproductpricetextbox);
            this.Controls.Add(this.quantitylabel);
            this.Controls.Add(this.pricetextbox1);
            this.Controls.Add(this.customernumbertextbox);
            this.Controls.Add(this.customernametextbox);
            this.Controls.Add(this.productlabel);
            this.Controls.Add(this.customernamelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.namelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hotel management ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox customernametextbox;
        private System.Windows.Forms.Label customernamelabel;
        private System.Windows.Forms.TextBox totalproductpricetextbox;
        private System.Windows.Forms.Label productlabel;
        private System.Windows.Forms.ComboBox productnamecombobox;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.ComboBox quantitycombobox;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label totalpricelabel;
        private System.Windows.Forms.TextBox customernumbertextbox;
        private System.Windows.Forms.Button addnewcustomerbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button printpreviewbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox pricetextbox1;
        private System.Drawing.Printing.PrintDocument printDocumentbilldetail1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogbill;
    }
}

