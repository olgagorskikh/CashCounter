namespace CashCounter.UserInterfaceLayer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lLastDate = new System.Windows.Forms.Label();
            this.lLastTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPayer1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtTo1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFrom1 = new System.Windows.Forms.DateTimePicker();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategories1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAuthors = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvgResults = new System.Windows.Forms.DataGridView();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.tbShow = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.bsAllProducts = new System.Windows.Forms.BindingSource(this.components);
            this.bsAuthors = new System.Windows.Forms.BindingSource(this.components);
            this.bsResults = new System.Windows.Forms.BindingSource(this.components);
            this.bsCategories1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsAuthors1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthors1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lLastDate);
            this.panel1.Controls.Add(this.lLastTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lDate);
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 617);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Balance";
            // 
            // lLastDate
            // 
            this.lLastDate.AutoSize = true;
            this.lLastDate.Location = new System.Drawing.Point(3, 95);
            this.lLastDate.Name = "lLastDate";
            this.lLastDate.Size = new System.Drawing.Size(61, 13);
            this.lLastDate.TabIndex = 15;
            this.lLastDate.Text = "15.08.2003";
            // 
            // lLastTotal
            // 
            this.lLastTotal.AutoSize = true;
            this.lLastTotal.Location = new System.Drawing.Point(154, 95);
            this.lLastTotal.Name = "lLastTotal";
            this.lLastTotal.Size = new System.Drawing.Size(34, 13);
            this.lLastTotal.TabIndex = 14;
            this.lLastTotal.Text = "13,20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last purchases";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(3, 27);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(61, 13);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "03.02.2015";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTotal.Location = new System.Drawing.Point(105, 10);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(90, 26);
            this.lTotal.TabIndex = 0;
            this.lTotal.Text = "1808,25";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 617);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbAuthors);
            this.tabPage1.Controls.Add(this.bSave);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bUpdate);
            this.tabPage1.Controls.Add(this.dgvProducts);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtPicker);
            this.tabPage1.Controls.Add(this.tbPrice);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbCategories);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All purchases";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbPayer1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtTo1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFrom1);
            this.groupBox2.Controls.Add(this.tbKey);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbCategories1);
            this.groupBox2.Location = new System.Drawing.Point(263, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 115);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(570, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Payer";
            // 
            // cbPayer1
            // 
            this.cbPayer1.FormattingEnabled = true;
            this.cbPayer1.Location = new System.Drawing.Point(573, 62);
            this.cbPayer1.Name = "cbPayer1";
            this.cbPayer1.Size = new System.Drawing.Size(129, 21);
            this.cbPayer1.Sorted = true;
            this.cbPayer1.TabIndex = 15;
            this.cbPayer1.SelectedIndexChanged += new System.EventHandler(this.cbPayer1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(468, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "To";
            // 
            // dtTo1
            // 
            this.dtTo1.Location = new System.Drawing.Point(471, 63);
            this.dtTo1.Name = "dtTo1";
            this.dtTo1.Size = new System.Drawing.Size(80, 20);
            this.dtTo1.TabIndex = 11;
            this.dtTo1.ValueChanged += new System.EventHandler(this.dtTo1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "From";
            // 
            // dtFrom1
            // 
            this.dtFrom1.Location = new System.Drawing.Point(369, 63);
            this.dtFrom1.Name = "dtFrom1";
            this.dtFrom1.Size = new System.Drawing.Size(80, 20);
            this.dtFrom1.TabIndex = 9;
            this.dtFrom1.ValueChanged += new System.EventHandler(this.dtFrom1_ValueChanged);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(206, 63);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(142, 20);
            this.tbKey.TabIndex = 5;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Key words";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Category";
            // 
            // cbCategories1
            // 
            this.cbCategories1.FormattingEnabled = true;
            this.cbCategories1.Location = new System.Drawing.Point(28, 63);
            this.cbCategories1.Name = "cbCategories1";
            this.cbCategories1.Size = new System.Drawing.Size(154, 21);
            this.cbCategories1.Sorted = true;
            this.cbCategories1.TabIndex = 2;
            this.cbCategories1.SelectedValueChanged += new System.EventHandler(this.cbCategories1_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Select payer";
            // 
            // cbAuthors
            // 
            this.cbAuthors.FormattingEnabled = true;
            this.cbAuthors.Location = new System.Drawing.Point(9, 377);
            this.cbAuthors.Name = "cbAuthors";
            this.cbAuthors.Size = new System.Drawing.Size(230, 21);
            this.cbAuthors.Sorted = true;
            this.cbAuthors.TabIndex = 14;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(154, 447);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(85, 23);
            this.bSave.TabIndex = 13;
            this.bSave.Text = "Добавить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSaveProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adding a new purchase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recent purchases";
            // 
            // bUpdate
            // 
            this.bUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUpdate.FlatAppearance.BorderSize = 0;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.bUpdate.Image = ((System.Drawing.Image)(resources.GetObject("bUpdate.Image")));
            this.bUpdate.Location = new System.Drawing.Point(983, 6);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(25, 25);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click_1);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(263, 170);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.Size = new System.Drawing.Size(728, 399);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select purchase date";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(9, 291);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(230, 20);
            this.dtPicker.TabIndex = 7;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(9, 214);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(230, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter item cost";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(9, 141);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(230, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter item description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select category";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(9, 71);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(230, 21);
            this.cbCategories.Sorted = true;
            this.cbCategories.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvgResults);
            this.tabPage2.Controls.Add(this.dtTo);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dtFrom);
            this.tabPage2.Controls.Add(this.tbShow);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvgResults
            // 
            this.dvgResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResults.Location = new System.Drawing.Point(289, 18);
            this.dvgResults.Name = "dvgResults";
            this.dvgResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dvgResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgResults.Size = new System.Drawing.Size(373, 459);
            this.dvgResults.TabIndex = 33;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(150, 186);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(103, 20);
            this.dtTo.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetails);
            this.groupBox1.Controls.Add(this.rbGeneral);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 108);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report type";
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Checked = true;
            this.rbDetails.Location = new System.Drawing.Point(43, 31);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(94, 17);
            this.rbDetails.TabIndex = 29;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "Detailed report";
            this.rbDetails.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(43, 68);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(92, 17);
            this.rbGeneral.TabIndex = 30;
            this.rbGeneral.Text = "General report";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(23, 186);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(103, 20);
            this.dtFrom.TabIndex = 27;
            // 
            // tbShow
            // 
            this.tbShow.Location = new System.Drawing.Point(139, 250);
            this.tbShow.Name = "tbShow";
            this.tbShow.Size = new System.Drawing.Size(114, 23);
            this.tbShow.TabIndex = 24;
            this.tbShow.Text = "Show";
            this.tbShow.UseVisualStyleBackColor = true;
            this.tbShow.Click += new System.EventHandler(this.tbShow_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "To";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Private accounting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthors1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.BindingSource bsAllProducts;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lLastDate;
        private System.Windows.Forms.Label lLastTotal;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAuthors;
        private System.Windows.Forms.BindingSource bsAuthors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button tbShow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dvgResults;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.BindingSource bsResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbPayer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtTo1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFrom1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategories1;
        private System.Windows.Forms.BindingSource bsCategories1;
        private System.Windows.Forms.BindingSource bsAuthors1;
    }
}