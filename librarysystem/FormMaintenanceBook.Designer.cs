namespace SA43Team4B
{
    partial class FormMaintenanceBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaintenanceBook));
            this.tabBookControl = new System.Windows.Forms.TabControl();
            this.tabAddNewBook = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.txtSheldDetails = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtWordNumber = new System.Windows.Forms.TextBox();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.lblBookFormat = new System.Windows.Forms.Label();
            this.lblWordNumber = new System.Windows.Forms.Label();
            this.lblStockNum = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookEdition = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.ModifyTabPage = new System.Windows.Forms.TabPage();
            this.pnlModifyBook = new System.Windows.Forms.Panel();
            this.cboMISBN = new System.Windows.Forms.ComboBox();
            this.lblSheldDetail = new System.Windows.Forms.Label();
            this.txtMSheldDetails = new System.Windows.Forms.TextBox();
            this.txtMCategory = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtMBookFormat = new System.Windows.Forms.TextBox();
            this.txtMWordNumber = new System.Windows.Forms.TextBox();
            this.txtMRented = new System.Windows.Forms.TextBox();
            this.txtMStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMPrice = new System.Windows.Forms.TextBox();
            this.txtMEdition = new System.Windows.Forms.TextBox();
            this.txtMPress = new System.Windows.Forms.TextBox();
            this.txtMAuthor = new System.Windows.Forms.TextBox();
            this.txtMTitle = new System.Windows.Forms.TextBox();
            this.txtMISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShowPosition = new System.Windows.Forms.Label();
            this.tabBookControl.SuspendLayout();
            this.tabAddNewBook.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ModifyTabPage.SuspendLayout();
            this.pnlModifyBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBookControl
            // 
            this.tabBookControl.Controls.Add(this.tabAddNewBook);
            this.tabBookControl.Controls.Add(this.ModifyTabPage);
            this.tabBookControl.Location = new System.Drawing.Point(12, 88);
            this.tabBookControl.Name = "tabBookControl";
            this.tabBookControl.SelectedIndex = 0;
            this.tabBookControl.Size = new System.Drawing.Size(803, 323);
            this.tabBookControl.TabIndex = 16;
            this.tabBookControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabBookControl_Selected);
            // 
            // tabAddNewBook
            // 
            this.tabAddNewBook.Controls.Add(this.panel1);
            this.tabAddNewBook.Location = new System.Drawing.Point(4, 22);
            this.tabAddNewBook.Name = "tabAddNewBook";
            this.tabAddNewBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddNewBook.Size = new System.Drawing.Size(795, 297);
            this.tabAddNewBook.TabIndex = 0;
            this.tabAddNewBook.Text = "Add New Book";
            this.tabAddNewBook.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBookCategory);
            this.panel1.Controls.Add(this.txtSheldDetails);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtFormat);
            this.panel1.Controls.Add(this.txtWordNumber);
            this.panel1.Controls.Add(this.txtStockNumber);
            this.panel1.Controls.Add(this.lblBookFormat);
            this.panel1.Controls.Add(this.lblWordNumber);
            this.panel1.Controls.Add(this.lblStockNum);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtEdition);
            this.panel1.Controls.Add(this.txtPress);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblBookPrice);
            this.panel1.Controls.Add(this.lblBookEdition);
            this.panel1.Controls.Add(this.lblPress);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblBookTitle);
            this.panel1.Controls.Add(this.lblBookISBN);
            this.panel1.Location = new System.Drawing.Point(-3, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 326);
            this.panel1.TabIndex = 11;
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(189, 91);
            this.txtBookCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(170, 20);
            this.txtBookCategory.TabIndex = 31;
            // 
            // txtSheldDetails
            // 
            this.txtSheldDetails.Location = new System.Drawing.Point(539, 163);
            this.txtSheldDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtSheldDetails.Multiline = true;
            this.txtSheldDetails.Name = "txtSheldDetails";
            this.txtSheldDetails.Size = new System.Drawing.Size(170, 40);
            this.txtSheldDetails.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 163);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Shelf Details";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(539, 127);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(170, 20);
            this.txtFormat.TabIndex = 28;
            // 
            // txtWordNumber
            // 
            this.txtWordNumber.Location = new System.Drawing.Point(539, 89);
            this.txtWordNumber.Name = "txtWordNumber";
            this.txtWordNumber.Size = new System.Drawing.Size(170, 20);
            this.txtWordNumber.TabIndex = 27;
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Location = new System.Drawing.Point(539, 54);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(170, 20);
            this.txtStockNumber.TabIndex = 25;
            // 
            // lblBookFormat
            // 
            this.lblBookFormat.AutoSize = true;
            this.lblBookFormat.Location = new System.Drawing.Point(395, 127);
            this.lblBookFormat.Name = "lblBookFormat";
            this.lblBookFormat.Size = new System.Drawing.Size(67, 13);
            this.lblBookFormat.TabIndex = 24;
            this.lblBookFormat.Text = "Book Format";
            // 
            // lblWordNumber
            // 
            this.lblWordNumber.AutoSize = true;
            this.lblWordNumber.Location = new System.Drawing.Point(395, 91);
            this.lblWordNumber.Name = "lblWordNumber";
            this.lblWordNumber.Size = new System.Drawing.Size(101, 13);
            this.lblWordNumber.TabIndex = 23;
            this.lblWordNumber.Text = "Book Word Number";
            // 
            // lblStockNum
            // 
            this.lblStockNum.AutoSize = true;
            this.lblStockNum.Location = new System.Drawing.Point(393, 57);
            this.lblStockNum.Name = "lblStockNum";
            this.lblStockNum.Size = new System.Drawing.Size(103, 13);
            this.lblStockNum.TabIndex = 21;
            this.lblStockNum.Text = "Book Stock Number";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(591, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(539, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 20);
            this.txtPrice.TabIndex = 19;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(189, 193);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(170, 20);
            this.txtEdition.TabIndex = 18;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(189, 159);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(170, 20);
            this.txtPress.TabIndex = 17;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(189, 124);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(170, 20);
            this.txtAuthor.TabIndex = 16;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(189, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(170, 20);
            this.txtTitle.TabIndex = 14;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(189, 19);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(170, 20);
            this.txtISBN.TabIndex = 12;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(393, 22);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(59, 13);
            this.lblBookPrice.TabIndex = 7;
            this.lblBookPrice.Text = "Book Price";
            // 
            // lblBookEdition
            // 
            this.lblBookEdition.AutoSize = true;
            this.lblBookEdition.Location = new System.Drawing.Point(67, 195);
            this.lblBookEdition.Name = "lblBookEdition";
            this.lblBookEdition.Size = new System.Drawing.Size(67, 13);
            this.lblBookEdition.TabIndex = 6;
            this.lblBookEdition.Text = "Book Edition";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(67, 163);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(61, 13);
            this.lblPress.TabIndex = 5;
            this.lblPress.Text = "Book Press";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(67, 125);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Book Author";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(67, 91);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Book Category";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(67, 57);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(67, 22);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(60, 13);
            this.lblBookISBN.TabIndex = 0;
            this.lblBookISBN.Text = "Book ISBN";
            // 
            // ModifyTabPage
            // 
            this.ModifyTabPage.Controls.Add(this.pnlModifyBook);
            this.ModifyTabPage.Location = new System.Drawing.Point(4, 22);
            this.ModifyTabPage.Name = "ModifyTabPage";
            this.ModifyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTabPage.Size = new System.Drawing.Size(795, 297);
            this.ModifyTabPage.TabIndex = 1;
            this.ModifyTabPage.Text = "Modify Book";
            this.ModifyTabPage.UseVisualStyleBackColor = true;
            // 
            // pnlModifyBook
            // 
            this.pnlModifyBook.Controls.Add(this.cboMISBN);
            this.pnlModifyBook.Controls.Add(this.lblSheldDetail);
            this.pnlModifyBook.Controls.Add(this.txtMSheldDetails);
            this.pnlModifyBook.Controls.Add(this.txtMCategory);
            this.pnlModifyBook.Controls.Add(this.btnPrevious);
            this.pnlModifyBook.Controls.Add(this.btnNext);
            this.pnlModifyBook.Controls.Add(this.btnFirst);
            this.pnlModifyBook.Controls.Add(this.btnLast);
            this.pnlModifyBook.Controls.Add(this.txtMBookFormat);
            this.pnlModifyBook.Controls.Add(this.txtMWordNumber);
            this.pnlModifyBook.Controls.Add(this.txtMRented);
            this.pnlModifyBook.Controls.Add(this.txtMStock);
            this.pnlModifyBook.Controls.Add(this.label1);
            this.pnlModifyBook.Controls.Add(this.label2);
            this.pnlModifyBook.Controls.Add(this.label3);
            this.pnlModifyBook.Controls.Add(this.label4);
            this.pnlModifyBook.Controls.Add(this.btnDelete);
            this.pnlModifyBook.Controls.Add(this.btnUpdate);
            this.pnlModifyBook.Controls.Add(this.txtMPrice);
            this.pnlModifyBook.Controls.Add(this.txtMEdition);
            this.pnlModifyBook.Controls.Add(this.txtMPress);
            this.pnlModifyBook.Controls.Add(this.txtMAuthor);
            this.pnlModifyBook.Controls.Add(this.txtMTitle);
            this.pnlModifyBook.Controls.Add(this.txtMISBN);
            this.pnlModifyBook.Controls.Add(this.label5);
            this.pnlModifyBook.Controls.Add(this.label6);
            this.pnlModifyBook.Controls.Add(this.label7);
            this.pnlModifyBook.Controls.Add(this.label8);
            this.pnlModifyBook.Controls.Add(this.label9);
            this.pnlModifyBook.Controls.Add(this.label10);
            this.pnlModifyBook.Controls.Add(this.label12);
            this.pnlModifyBook.Location = new System.Drawing.Point(5, 1);
            this.pnlModifyBook.Name = "pnlModifyBook";
            this.pnlModifyBook.Size = new System.Drawing.Size(789, 293);
            this.pnlModifyBook.TabIndex = 15;
            // 
            // cboMISBN
            // 
            this.cboMISBN.FormattingEnabled = true;
            this.cboMISBN.Location = new System.Drawing.Point(189, 18);
            this.cboMISBN.Name = "cboMISBN";
            this.cboMISBN.Size = new System.Drawing.Size(203, 21);
            this.cboMISBN.TabIndex = 36;
            this.cboMISBN.TextChanged += new System.EventHandler(this.cboMISBN_TextChanged);
            // 
            // lblSheldDetail
            // 
            this.lblSheldDetail.AutoSize = true;
            this.lblSheldDetail.Location = new System.Drawing.Point(427, 185);
            this.lblSheldDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSheldDetail.Name = "lblSheldDetail";
            this.lblSheldDetail.Size = new System.Drawing.Size(66, 13);
            this.lblSheldDetail.TabIndex = 35;
            this.lblSheldDetail.Text = "Shelf Details";
            // 
            // txtMSheldDetails
            // 
            this.txtMSheldDetails.Location = new System.Drawing.Point(557, 183);
            this.txtMSheldDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSheldDetails.Multiline = true;
            this.txtMSheldDetails.Name = "txtMSheldDetails";
            this.txtMSheldDetails.Size = new System.Drawing.Size(201, 47);
            this.txtMSheldDetails.TabIndex = 34;
            // 
            // txtMCategory
            // 
            this.txtMCategory.Location = new System.Drawing.Point(189, 90);
            this.txtMCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtMCategory.Name = "txtMCategory";
            this.txtMCategory.Size = new System.Drawing.Size(203, 20);
            this.txtMCategory.TabIndex = 33;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(129, 247);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 31);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(454, 247);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 31);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(42, 247);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(82, 31);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(536, 247);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 31);
            this.btnLast.TabIndex = 29;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtMBookFormat
            // 
            this.txtMBookFormat.Location = new System.Drawing.Point(557, 157);
            this.txtMBookFormat.Name = "txtMBookFormat";
            this.txtMBookFormat.Size = new System.Drawing.Size(201, 20);
            this.txtMBookFormat.TabIndex = 28;
            // 
            // txtMWordNumber
            // 
            this.txtMWordNumber.Location = new System.Drawing.Point(557, 123);
            this.txtMWordNumber.Name = "txtMWordNumber";
            this.txtMWordNumber.Size = new System.Drawing.Size(201, 20);
            this.txtMWordNumber.TabIndex = 27;
            // 
            // txtMRented
            // 
            this.txtMRented.Location = new System.Drawing.Point(557, 90);
            this.txtMRented.Name = "txtMRented";
            this.txtMRented.Size = new System.Drawing.Size(201, 20);
            this.txtMRented.TabIndex = 26;
            // 
            // txtMStock
            // 
            this.txtMStock.Location = new System.Drawing.Point(557, 56);
            this.txtMStock.Name = "txtMStock";
            this.txtMStock.Size = new System.Drawing.Size(201, 20);
            this.txtMStock.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Book Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Word Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Number of Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Book Stock Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Decommit";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMPrice
            // 
            this.txtMPrice.Location = new System.Drawing.Point(557, 21);
            this.txtMPrice.Name = "txtMPrice";
            this.txtMPrice.Size = new System.Drawing.Size(201, 20);
            this.txtMPrice.TabIndex = 19;
            // 
            // txtMEdition
            // 
            this.txtMEdition.Location = new System.Drawing.Point(189, 195);
            this.txtMEdition.Name = "txtMEdition";
            this.txtMEdition.Size = new System.Drawing.Size(201, 20);
            this.txtMEdition.TabIndex = 18;
            // 
            // txtMPress
            // 
            this.txtMPress.Location = new System.Drawing.Point(189, 159);
            this.txtMPress.Name = "txtMPress";
            this.txtMPress.Size = new System.Drawing.Size(201, 20);
            this.txtMPress.TabIndex = 17;
            // 
            // txtMAuthor
            // 
            this.txtMAuthor.Location = new System.Drawing.Point(189, 123);
            this.txtMAuthor.Name = "txtMAuthor";
            this.txtMAuthor.Size = new System.Drawing.Size(201, 20);
            this.txtMAuthor.TabIndex = 16;
            // 
            // txtMTitle
            // 
            this.txtMTitle.Location = new System.Drawing.Point(189, 56);
            this.txtMTitle.Name = "txtMTitle";
            this.txtMTitle.Size = new System.Drawing.Size(201, 20);
            this.txtMTitle.TabIndex = 14;
            // 
            // txtMISBN
            // 
            this.txtMISBN.Location = new System.Drawing.Point(42, 221);
            this.txtMISBN.Name = "txtMISBN";
            this.txtMISBN.ReadOnly = true;
            this.txtMISBN.Size = new System.Drawing.Size(201, 20);
            this.txtMISBN.TabIndex = 12;
            this.txtMISBN.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Book Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Book Edition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Book Press";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Book Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Book Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Book Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Book ISBN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 70);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // lblShowPosition
            // 
            this.lblShowPosition.AutoSize = true;
            this.lblShowPosition.Location = new System.Drawing.Point(15, 414);
            this.lblShowPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowPosition.Name = "lblShowPosition";
            this.lblShowPosition.Size = new System.Drawing.Size(13, 13);
            this.lblShowPosition.TabIndex = 17;
            this.lblShowPosition.Text = "..";
            // 
            // FormMaintenanceBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 448);
            this.Controls.Add(this.lblShowPosition);
            this.Controls.Add(this.tabBookControl);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FormMaintenanceBook";
            this.Text = "Book Maintenance";
            this.Load += new System.EventHandler(this.FormBookMaintenance_Load);
            this.tabBookControl.ResumeLayout(false);
            this.tabAddNewBook.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ModifyTabPage.ResumeLayout(false);
            this.pnlModifyBook.ResumeLayout(false);
            this.pnlModifyBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabBookControl;
        private System.Windows.Forms.TabPage tabAddNewBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.TextBox txtSheldDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtWordNumber;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.Label lblBookFormat;
        private System.Windows.Forms.Label lblWordNumber;
        private System.Windows.Forms.Label lblStockNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookEdition;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.TabPage ModifyTabPage;
        private System.Windows.Forms.Panel pnlModifyBook;
        private System.Windows.Forms.Label lblSheldDetail;
        private System.Windows.Forms.TextBox txtMSheldDetails;
        private System.Windows.Forms.TextBox txtMCategory;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtMBookFormat;
        private System.Windows.Forms.TextBox txtMWordNumber;
        private System.Windows.Forms.TextBox txtMRented;
        private System.Windows.Forms.TextBox txtMStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMPrice;
        private System.Windows.Forms.TextBox txtMEdition;
        private System.Windows.Forms.TextBox txtMPress;
        private System.Windows.Forms.TextBox txtMAuthor;
        private System.Windows.Forms.TextBox txtMTitle;
        private System.Windows.Forms.TextBox txtMISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShowPosition;
        private System.Windows.Forms.ComboBox cboMISBN;

    }
}