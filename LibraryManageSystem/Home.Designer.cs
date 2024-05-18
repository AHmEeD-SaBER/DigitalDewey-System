namespace LibraryManageSystem
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            sideBar = new FlowLayoutPanel();
            logo = new FlowLayoutPanel();
            List = new PictureBox();
            logoLB = new Label();
            Homebtn = new Button();
            updateProfileBtn = new Button();
            updateBookbtn = new Button();
            addBookbtn = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            homePanel = new Panel();
            booksDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            listLB = new Label();
            Title = new Label();
            addBookPanel = new Panel();
            addBtn = new Button();
            priceBox = new TextBox();
            priceLB = new Label();
            publisherBox = new TextBox();
            publisherLB = new Label();
            ISBNBox = new TextBox();
            ISBNLB = new Label();
            authorBox = new TextBox();
            authorLB = new Label();
            categoryBox = new TextBox();
            categoryLB = new Label();
            titleBox = new TextBox();
            titleLB = new Label();
            addedBooksDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            updateBookPanel = new Panel();
            deleteBookBtn = new Button();
            saveBtn = new Button();
            addPriceBox = new TextBox();
            addPriceLb = new Label();
            addPubBox = new TextBox();
            addPubLb = new Label();
            addAuthorBox = new TextBox();
            addAuthorLb = new Label();
            addCatBox = new TextBox();
            addCatLb = new Label();
            addTitleBox = new TextBox();
            addTitleLb = new Label();
            updatedBooksDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label8 = new Label();
            userPanel = new Panel();
            showPassBtn1 = new Button();
            viewBooksBtn = new Button();
            saveUserBtn = new Button();
            deleteUserBtn = new Button();
            passBox = new TextBox();
            userPassLB = new Label();
            userNameBox = new TextBox();
            userNameLB = new Label();
            userLB = new Label();
            bookDetails = new Panel();
            borrowBtn = new Button();
            prBX = new Label();
            pBX = new Label();
            cBX = new Label();
            aBX = new Label();
            prLB = new Label();
            cLB = new Label();
            pLB = new Label();
            aLB = new Label();
            mainLB = new Label();
            borrowedBookspanel = new Panel();
            headLB = new Label();
            borrowedBooksDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            sideBar.SuspendLayout();
            logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)List).BeginInit();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDGV).BeginInit();
            addBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addedBooksDGV).BeginInit();
            updateBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updatedBooksDGV).BeginInit();
            userPanel.SuspendLayout();
            bookDetails.SuspendLayout();
            borrowedBookspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowedBooksDGV).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sideBar.BackColor = Color.FromArgb(18, 18, 18);
            sideBar.Controls.Add(logo);
            sideBar.Controls.Add(Homebtn);
            sideBar.Controls.Add(updateProfileBtn);
            sideBar.Controls.Add(updateBookbtn);
            sideBar.Controls.Add(addBookbtn);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(325, 0);
            sideBar.MinimumSize = new Size(60, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(68, 706);
            sideBar.TabIndex = 2;
            // 
            // logo
            // 
            logo.Controls.Add(List);
            logo.Controls.Add(logoLB);
            logo.Location = new Point(3, 3);
            logo.Name = "logo";
            logo.Size = new Size(310, 112);
            logo.TabIndex = 2;
            // 
            // List
            // 
            List.Cursor = Cursors.Hand;
            List.Image = (Image)resources.GetObject("List.Image");
            List.Location = new Point(3, 3);
            List.Name = "List";
            List.Size = new Size(49, 55);
            List.TabIndex = 1;
            List.TabStop = false;
            List.Click += List_Click;
            // 
            // logoLB
            // 
            logoLB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            logoLB.ForeColor = Color.Aqua;
            logoLB.Location = new Point(58, 0);
            logoLB.Name = "logoLB";
            logoLB.Size = new Size(233, 58);
            logoLB.TabIndex = 2;
            logoLB.Text = "DigitalDewey";
            // 
            // Homebtn
            // 
            Homebtn.FlatAppearance.BorderSize = 0;
            Homebtn.FlatStyle = FlatStyle.Flat;
            Homebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Homebtn.ForeColor = Color.White;
            Homebtn.Image = (Image)resources.GetObject("Homebtn.Image");
            Homebtn.ImageAlign = ContentAlignment.MiddleLeft;
            Homebtn.Location = new Point(3, 121);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(310, 72);
            Homebtn.TabIndex = 3;
            Homebtn.Text = "  Home";
            Homebtn.TextAlign = ContentAlignment.MiddleLeft;
            Homebtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Homebtn.UseVisualStyleBackColor = true;
            Homebtn.Click += Homebtn_Click;
            // 
            // updateProfileBtn
            // 
            updateProfileBtn.FlatAppearance.BorderSize = 0;
            updateProfileBtn.FlatStyle = FlatStyle.Flat;
            updateProfileBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            updateProfileBtn.ForeColor = Color.White;
            updateProfileBtn.Image = (Image)resources.GetObject("updateProfileBtn.Image");
            updateProfileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateProfileBtn.Location = new Point(3, 199);
            updateProfileBtn.Name = "updateProfileBtn";
            updateProfileBtn.Size = new Size(296, 72);
            updateProfileBtn.TabIndex = 3;
            updateProfileBtn.Text = "  Update Profile";
            updateProfileBtn.TextAlign = ContentAlignment.MiddleLeft;
            updateProfileBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateProfileBtn.UseVisualStyleBackColor = true;
            updateProfileBtn.Click += userBtn_Click;
            // 
            // updateBookbtn
            // 
            updateBookbtn.FlatAppearance.BorderSize = 0;
            updateBookbtn.FlatStyle = FlatStyle.Flat;
            updateBookbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            updateBookbtn.ForeColor = Color.White;
            updateBookbtn.Image = (Image)resources.GetObject("updateBookbtn.Image");
            updateBookbtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateBookbtn.Location = new Point(3, 277);
            updateBookbtn.Name = "updateBookbtn";
            updateBookbtn.Padding = new Padding(3, 0, 0, 0);
            updateBookbtn.Size = new Size(310, 72);
            updateBookbtn.TabIndex = 3;
            updateBookbtn.Text = "  Update Book Details";
            updateBookbtn.TextAlign = ContentAlignment.MiddleLeft;
            updateBookbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateBookbtn.UseVisualStyleBackColor = true;
            updateBookbtn.Click += updateBookbtn_Click;
            // 
            // addBookbtn
            // 
            addBookbtn.FlatAppearance.BorderSize = 0;
            addBookbtn.FlatStyle = FlatStyle.Flat;
            addBookbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addBookbtn.ForeColor = Color.White;
            addBookbtn.Image = (Image)resources.GetObject("addBookbtn.Image");
            addBookbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBookbtn.Location = new Point(3, 355);
            addBookbtn.Name = "addBookbtn";
            addBookbtn.Padding = new Padding(2, 0, 0, 0);
            addBookbtn.Size = new Size(310, 72);
            addBookbtn.TabIndex = 4;
            addBookbtn.Text = "  Add Book";
            addBookbtn.TextAlign = ContentAlignment.MiddleLeft;
            addBookbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBookbtn.UseVisualStyleBackColor = true;
            addBookbtn.Click += addBookbtn_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 2;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // homePanel
            // 
            homePanel.Controls.Add(booksDGV);
            homePanel.Controls.Add(listLB);
            homePanel.Controls.Add(Title);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(68, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1080, 706);
            homePanel.TabIndex = 3;
            // 
            // booksDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            booksDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            booksDGV.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            booksDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            booksDGV.ColumnHeadersHeight = 40;
            booksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            booksDGV.DefaultCellStyle = dataGridViewCellStyle3;
            booksDGV.GridColor = Color.FromArgb(231, 229, 255);
            booksDGV.Location = new Point(40, 248);
            booksDGV.Name = "booksDGV";
            booksDGV.ReadOnly = true;
            booksDGV.RowHeadersVisible = false;
            booksDGV.RowHeadersWidth = 51;
            booksDGV.RowTemplate.Height = 29;
            booksDGV.Size = new Size(1007, 437);
            booksDGV.TabIndex = 9;
            booksDGV.TabStop = false;
            booksDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            booksDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            booksDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            booksDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            booksDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            booksDGV.ThemeStyle.BackColor = Color.DimGray;
            booksDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            booksDGV.ThemeStyle.HeaderStyle.BackColor = Color.Aqua;
            booksDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            booksDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            booksDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            booksDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            booksDGV.ThemeStyle.HeaderStyle.Height = 40;
            booksDGV.ThemeStyle.ReadOnly = true;
            booksDGV.ThemeStyle.RowsStyle.BackColor = Color.Aqua;
            booksDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            booksDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            booksDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            booksDGV.ThemeStyle.RowsStyle.Height = 29;
            booksDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            booksDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            booksDGV.CellClick += booksDGV_CellClick;
            // 
            // listLB
            // 
            listLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            listLB.ForeColor = Color.White;
            listLB.Location = new Point(40, 191);
            listLB.Name = "listLB";
            listLB.Size = new Size(241, 54);
            listLB.TabIndex = 8;
            listLB.Text = "Books List";
            // 
            // Title
            // 
            Title.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.Aqua;
            Title.Location = new Point(291, 22);
            Title.Name = "Title";
            Title.Size = new Size(449, 84);
            Title.TabIndex = 7;
            Title.Text = "Welcome In DigitalDewey";
            // 
            // addBookPanel
            // 
            addBookPanel.Controls.Add(addBtn);
            addBookPanel.Controls.Add(priceBox);
            addBookPanel.Controls.Add(priceLB);
            addBookPanel.Controls.Add(publisherBox);
            addBookPanel.Controls.Add(publisherLB);
            addBookPanel.Controls.Add(ISBNBox);
            addBookPanel.Controls.Add(ISBNLB);
            addBookPanel.Controls.Add(authorBox);
            addBookPanel.Controls.Add(authorLB);
            addBookPanel.Controls.Add(categoryBox);
            addBookPanel.Controls.Add(categoryLB);
            addBookPanel.Controls.Add(titleBox);
            addBookPanel.Controls.Add(titleLB);
            addBookPanel.Controls.Add(addedBooksDGV);
            addBookPanel.Controls.Add(label2);
            addBookPanel.Dock = DockStyle.Fill;
            addBookPanel.Location = new Point(68, 0);
            addBookPanel.Name = "addBookPanel";
            addBookPanel.Size = new Size(1080, 706);
            addBookPanel.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Aqua;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Black;
            addBtn.Location = new Point(454, 224);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(178, 49);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            priceBox.Location = new Point(805, 142);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(198, 34);
            priceBox.TabIndex = 23;
            // 
            // priceLB
            // 
            priceLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            priceLB.ForeColor = Color.White;
            priceLB.Location = new Point(707, 142);
            priceLB.Name = "priceLB";
            priceLB.Size = new Size(92, 34);
            priceLB.TabIndex = 22;
            priceLB.Text = "Price";
            // 
            // publisherBox
            // 
            publisherBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            publisherBox.Location = new Point(449, 142);
            publisherBox.Name = "publisherBox";
            publisherBox.Size = new Size(198, 34);
            publisherBox.TabIndex = 21;
            // 
            // publisherLB
            // 
            publisherLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            publisherLB.ForeColor = Color.White;
            publisherLB.Location = new Point(328, 142);
            publisherLB.Name = "publisherLB";
            publisherLB.Size = new Size(115, 34);
            publisherLB.TabIndex = 20;
            publisherLB.Text = "Publisher";
            // 
            // ISBNBox
            // 
            ISBNBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ISBNBox.Location = new Point(112, 142);
            ISBNBox.Name = "ISBNBox";
            ISBNBox.Size = new Size(198, 34);
            ISBNBox.TabIndex = 19;
            // 
            // ISBNLB
            // 
            ISBNLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ISBNLB.ForeColor = Color.White;
            ISBNLB.Location = new Point(40, 142);
            ISBNLB.Name = "ISBNLB";
            ISBNLB.Size = new Size(66, 34);
            ISBNLB.TabIndex = 18;
            ISBNLB.Text = "ISBN";
            // 
            // authorBox
            // 
            authorBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            authorBox.Location = new Point(805, 61);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(198, 34);
            authorBox.TabIndex = 17;
            // 
            // authorLB
            // 
            authorLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            authorLB.ForeColor = Color.White;
            authorLB.Location = new Point(707, 61);
            authorLB.Name = "authorLB";
            authorLB.Size = new Size(92, 34);
            authorLB.TabIndex = 16;
            authorLB.Text = "Author";
            // 
            // categoryBox
            // 
            categoryBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryBox.Location = new Point(449, 61);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(198, 34);
            categoryBox.TabIndex = 15;
            // 
            // categoryLB
            // 
            categoryLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLB.ForeColor = Color.White;
            categoryLB.Location = new Point(328, 61);
            categoryLB.Name = "categoryLB";
            categoryLB.Size = new Size(115, 34);
            categoryLB.TabIndex = 14;
            categoryLB.Text = "Category";
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titleBox.Location = new Point(112, 61);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(198, 34);
            titleBox.TabIndex = 13;
            // 
            // titleLB
            // 
            titleLB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titleLB.ForeColor = Color.White;
            titleLB.Location = new Point(40, 61);
            titleLB.Name = "titleLB";
            titleLB.Size = new Size(66, 34);
            titleLB.TabIndex = 12;
            titleLB.Text = "Tilte";
            // 
            // addedBooksDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            addedBooksDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            addedBooksDGV.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            addedBooksDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            addedBooksDGV.ColumnHeadersHeight = 40;
            addedBooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            addedBooksDGV.DefaultCellStyle = dataGridViewCellStyle6;
            addedBooksDGV.GridColor = Color.FromArgb(231, 229, 255);
            addedBooksDGV.Location = new Point(40, 359);
            addedBooksDGV.Name = "addedBooksDGV";
            addedBooksDGV.ReadOnly = true;
            addedBooksDGV.RowHeadersVisible = false;
            addedBooksDGV.RowHeadersWidth = 51;
            addedBooksDGV.RowTemplate.Height = 29;
            addedBooksDGV.Size = new Size(1007, 308);
            addedBooksDGV.TabIndex = 11;
            addedBooksDGV.TabStop = false;
            addedBooksDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            addedBooksDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            addedBooksDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            addedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            addedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            addedBooksDGV.ThemeStyle.BackColor = Color.DimGray;
            addedBooksDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            addedBooksDGV.ThemeStyle.HeaderStyle.BackColor = Color.Aqua;
            addedBooksDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            addedBooksDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addedBooksDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            addedBooksDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            addedBooksDGV.ThemeStyle.HeaderStyle.Height = 40;
            addedBooksDGV.ThemeStyle.ReadOnly = true;
            addedBooksDGV.ThemeStyle.RowsStyle.BackColor = Color.Aqua;
            addedBooksDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            addedBooksDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addedBooksDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            addedBooksDGV.ThemeStyle.RowsStyle.Height = 29;
            addedBooksDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            addedBooksDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 302);
            label2.Name = "label2";
            label2.Size = new Size(241, 54);
            label2.TabIndex = 10;
            label2.Text = "Books List";
            // 
            // updateBookPanel
            // 
            updateBookPanel.Controls.Add(deleteBookBtn);
            updateBookPanel.Controls.Add(saveBtn);
            updateBookPanel.Controls.Add(addPriceBox);
            updateBookPanel.Controls.Add(addPriceLb);
            updateBookPanel.Controls.Add(addPubBox);
            updateBookPanel.Controls.Add(addPubLb);
            updateBookPanel.Controls.Add(addAuthorBox);
            updateBookPanel.Controls.Add(addAuthorLb);
            updateBookPanel.Controls.Add(addCatBox);
            updateBookPanel.Controls.Add(addCatLb);
            updateBookPanel.Controls.Add(addTitleBox);
            updateBookPanel.Controls.Add(addTitleLb);
            updateBookPanel.Controls.Add(updatedBooksDGV);
            updateBookPanel.Controls.Add(label8);
            updateBookPanel.Dock = DockStyle.Fill;
            updateBookPanel.Location = new Point(68, 0);
            updateBookPanel.Name = "updateBookPanel";
            updateBookPanel.Size = new Size(1080, 706);
            updateBookPanel.TabIndex = 26;
            // 
            // deleteBookBtn
            // 
            deleteBookBtn.BackColor = Color.Red;
            deleteBookBtn.FlatAppearance.BorderSize = 0;
            deleteBookBtn.FlatStyle = FlatStyle.Flat;
            deleteBookBtn.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBookBtn.ForeColor = Color.Black;
            deleteBookBtn.Location = new Point(675, 209);
            deleteBookBtn.Name = "deleteBookBtn";
            deleteBookBtn.Size = new Size(178, 49);
            deleteBookBtn.TabIndex = 40;
            deleteBookBtn.Text = "Delete";
            deleteBookBtn.UseVisualStyleBackColor = false;
            deleteBookBtn.Click += deleteBookBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Aqua;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.Black;
            saveBtn.Location = new Point(236, 209);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(178, 49);
            saveBtn.TabIndex = 39;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // addPriceBox
            // 
            addPriceBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addPriceBox.Location = new Point(684, 142);
            addPriceBox.Name = "addPriceBox";
            addPriceBox.Size = new Size(198, 34);
            addPriceBox.TabIndex = 38;
            // 
            // addPriceLb
            // 
            addPriceLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addPriceLb.ForeColor = Color.White;
            addPriceLb.Location = new Point(586, 142);
            addPriceLb.Name = "addPriceLb";
            addPriceLb.Size = new Size(92, 34);
            addPriceLb.TabIndex = 37;
            addPriceLb.Text = "Price";
            // 
            // addPubBox
            // 
            addPubBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addPubBox.Location = new Point(328, 142);
            addPubBox.Name = "addPubBox";
            addPubBox.Size = new Size(198, 34);
            addPubBox.TabIndex = 36;
            // 
            // addPubLb
            // 
            addPubLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addPubLb.ForeColor = Color.White;
            addPubLb.Location = new Point(207, 142);
            addPubLb.Name = "addPubLb";
            addPubLb.Size = new Size(115, 34);
            addPubLb.TabIndex = 35;
            addPubLb.Text = "Publisher";
            // 
            // addAuthorBox
            // 
            addAuthorBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addAuthorBox.Location = new Point(805, 50);
            addAuthorBox.Name = "addAuthorBox";
            addAuthorBox.Size = new Size(198, 34);
            addAuthorBox.TabIndex = 32;
            // 
            // addAuthorLb
            // 
            addAuthorLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addAuthorLb.ForeColor = Color.White;
            addAuthorLb.Location = new Point(707, 50);
            addAuthorLb.Name = "addAuthorLb";
            addAuthorLb.Size = new Size(92, 34);
            addAuthorLb.TabIndex = 31;
            addAuthorLb.Text = "Author";
            // 
            // addCatBox
            // 
            addCatBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addCatBox.Location = new Point(449, 50);
            addCatBox.Name = "addCatBox";
            addCatBox.Size = new Size(198, 34);
            addCatBox.TabIndex = 30;
            // 
            // addCatLb
            // 
            addCatLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addCatLb.ForeColor = Color.White;
            addCatLb.Location = new Point(328, 50);
            addCatLb.Name = "addCatLb";
            addCatLb.Size = new Size(115, 34);
            addCatLb.TabIndex = 29;
            addCatLb.Text = "Category";
            // 
            // addTitleBox
            // 
            addTitleBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addTitleBox.Location = new Point(112, 50);
            addTitleBox.Name = "addTitleBox";
            addTitleBox.Size = new Size(198, 34);
            addTitleBox.TabIndex = 28;
            // 
            // addTitleLb
            // 
            addTitleLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addTitleLb.ForeColor = Color.White;
            addTitleLb.Location = new Point(40, 50);
            addTitleLb.Name = "addTitleLb";
            addTitleLb.Size = new Size(66, 34);
            addTitleLb.TabIndex = 27;
            addTitleLb.Text = "Tilte";
            // 
            // updatedBooksDGV
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            updatedBooksDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            updatedBooksDGV.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            updatedBooksDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            updatedBooksDGV.ColumnHeadersHeight = 40;
            updatedBooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            updatedBooksDGV.DefaultCellStyle = dataGridViewCellStyle9;
            updatedBooksDGV.GridColor = Color.FromArgb(231, 229, 255);
            updatedBooksDGV.Location = new Point(40, 348);
            updatedBooksDGV.Name = "updatedBooksDGV";
            updatedBooksDGV.ReadOnly = true;
            updatedBooksDGV.RowHeadersVisible = false;
            updatedBooksDGV.RowHeadersWidth = 51;
            updatedBooksDGV.RowTemplate.Height = 29;
            updatedBooksDGV.Size = new Size(1007, 308);
            updatedBooksDGV.TabIndex = 26;
            updatedBooksDGV.TabStop = false;
            updatedBooksDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            updatedBooksDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            updatedBooksDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            updatedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            updatedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            updatedBooksDGV.ThemeStyle.BackColor = Color.DimGray;
            updatedBooksDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            updatedBooksDGV.ThemeStyle.HeaderStyle.BackColor = Color.Aqua;
            updatedBooksDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            updatedBooksDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            updatedBooksDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            updatedBooksDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            updatedBooksDGV.ThemeStyle.HeaderStyle.Height = 40;
            updatedBooksDGV.ThemeStyle.ReadOnly = true;
            updatedBooksDGV.ThemeStyle.RowsStyle.BackColor = Color.Aqua;
            updatedBooksDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            updatedBooksDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            updatedBooksDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            updatedBooksDGV.ThemeStyle.RowsStyle.Height = 29;
            updatedBooksDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            updatedBooksDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            updatedBooksDGV.CellContentClick += guna2DataGridView1_CellContentDoubleClick;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 291);
            label8.Name = "label8";
            label8.Size = new Size(241, 54);
            label8.TabIndex = 25;
            label8.Text = "Books List";
            // 
            // userPanel
            // 
            userPanel.Controls.Add(showPassBtn1);
            userPanel.Controls.Add(viewBooksBtn);
            userPanel.Controls.Add(saveUserBtn);
            userPanel.Controls.Add(deleteUserBtn);
            userPanel.Controls.Add(passBox);
            userPanel.Controls.Add(userPassLB);
            userPanel.Controls.Add(userNameBox);
            userPanel.Controls.Add(userNameLB);
            userPanel.Controls.Add(userLB);
            userPanel.Dock = DockStyle.Fill;
            userPanel.Location = new Point(68, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1080, 706);
            userPanel.TabIndex = 27;
            // 
            // showPassBtn1
            // 
            showPassBtn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPassBtn1.Location = new Point(844, 320);
            showPassBtn1.Name = "showPassBtn1";
            showPassBtn1.Size = new Size(94, 29);
            showPassBtn1.TabIndex = 8;
            showPassBtn1.Text = "show";
            showPassBtn1.UseVisualStyleBackColor = true;
            showPassBtn1.Click += showPassBtn1_Click;
            // 
            // viewBooksBtn
            // 
            viewBooksBtn.BackColor = Color.FromArgb(64, 64, 64);
            viewBooksBtn.Cursor = Cursors.Hand;
            viewBooksBtn.FlatStyle = FlatStyle.Popup;
            viewBooksBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewBooksBtn.ForeColor = Color.Aqua;
            viewBooksBtn.Location = new Point(260, 389);
            viewBooksBtn.Name = "viewBooksBtn";
            viewBooksBtn.Size = new Size(578, 62);
            viewBooksBtn.TabIndex = 7;
            viewBooksBtn.Text = "Borrowed Books";
            viewBooksBtn.UseVisualStyleBackColor = false;
            viewBooksBtn.Click += viewBooksBtn_Click;
            // 
            // saveUserBtn
            // 
            saveUserBtn.BackColor = Color.Aqua;
            saveUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveUserBtn.Location = new Point(909, 248);
            saveUserBtn.Name = "saveUserBtn";
            saveUserBtn.Size = new Size(94, 49);
            saveUserBtn.TabIndex = 6;
            saveUserBtn.Text = "Save";
            saveUserBtn.UseVisualStyleBackColor = false;
            saveUserBtn.Click += saveUserBtn_Click;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BackColor = Color.Red;
            deleteUserBtn.FlatStyle = FlatStyle.Flat;
            deleteUserBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteUserBtn.ForeColor = SystemColors.ButtonFace;
            deleteUserBtn.Location = new Point(392, 579);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(309, 67);
            deleteUserBtn.TabIndex = 5;
            deleteUserBtn.Text = "Delete the Account";
            deleteUserBtn.UseVisualStyleBackColor = false;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // passBox
            // 
            passBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            passBox.Location = new Point(446, 306);
            passBox.Name = "passBox";
            passBox.Size = new Size(392, 43);
            passBox.TabIndex = 4;
            passBox.TextChanged += textBox_Changed;
            // 
            // userPassLB
            // 
            userPassLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userPassLB.ForeColor = Color.White;
            userPassLB.Location = new Point(250, 303);
            userPassLB.Name = "userPassLB";
            userPassLB.Size = new Size(170, 46);
            userPassLB.TabIndex = 3;
            userPassLB.Text = "Password :";
            // 
            // userNameBox
            // 
            userNameBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userNameBox.Location = new Point(446, 202);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(392, 43);
            userNameBox.TabIndex = 2;
            userNameBox.TextChanged += textBox_Changed;
            // 
            // userNameLB
            // 
            userNameLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLB.ForeColor = Color.White;
            userNameLB.Location = new Point(250, 199);
            userNameLB.Name = "userNameLB";
            userNameLB.Size = new Size(170, 46);
            userNameLB.TabIndex = 1;
            userNameLB.Text = "Username :";
            // 
            // userLB
            // 
            userLB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            userLB.ForeColor = Color.Aqua;
            userLB.Location = new Point(436, 9);
            userLB.Name = "userLB";
            userLB.Size = new Size(217, 62);
            userLB.TabIndex = 0;
            userLB.Text = "User Profile";
            // 
            // bookDetails
            // 
            bookDetails.Controls.Add(borrowBtn);
            bookDetails.Controls.Add(prBX);
            bookDetails.Controls.Add(pBX);
            bookDetails.Controls.Add(cBX);
            bookDetails.Controls.Add(aBX);
            bookDetails.Controls.Add(prLB);
            bookDetails.Controls.Add(cLB);
            bookDetails.Controls.Add(pLB);
            bookDetails.Controls.Add(aLB);
            bookDetails.Controls.Add(mainLB);
            bookDetails.Dock = DockStyle.Fill;
            bookDetails.Location = new Point(0, 0);
            bookDetails.Name = "bookDetails";
            bookDetails.Size = new Size(1148, 706);
            bookDetails.TabIndex = 28;
            // 
            // borrowBtn
            // 
            borrowBtn.BackColor = Color.Aqua;
            borrowBtn.Cursor = Cursors.Hand;
            borrowBtn.FlatAppearance.BorderSize = 0;
            borrowBtn.FlatAppearance.MouseDownBackColor = Color.White;
            borrowBtn.FlatAppearance.MouseOverBackColor = Color.Aqua;
            borrowBtn.FlatStyle = FlatStyle.Popup;
            borrowBtn.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            borrowBtn.Location = new Point(332, 526);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(408, 65);
            borrowBtn.TabIndex = 9;
            borrowBtn.Text = "Borrow";
            borrowBtn.UseVisualStyleBackColor = false;
            borrowBtn.Click += borrowBtn_Click;
            // 
            // prBX
            // 
            prBX.BackColor = Color.Black;
            prBX.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            prBX.ForeColor = Color.MintCream;
            prBX.Location = new Point(520, 444);
            prBX.Name = "prBX";
            prBX.Size = new Size(291, 50);
            prBX.TabIndex = 8;
            // 
            // pBX
            // 
            pBX.BackColor = Color.Black;
            pBX.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            pBX.ForeColor = Color.MintCream;
            pBX.Location = new Point(520, 359);
            pBX.Name = "pBX";
            pBX.Size = new Size(291, 50);
            pBX.TabIndex = 7;
            // 
            // cBX
            // 
            cBX.BackColor = Color.Black;
            cBX.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cBX.ForeColor = Color.White;
            cBX.Location = new Point(520, 261);
            cBX.Name = "cBX";
            cBX.Size = new Size(291, 50);
            cBX.TabIndex = 6;
            // 
            // aBX
            // 
            aBX.BackColor = Color.Black;
            aBX.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            aBX.ForeColor = Color.White;
            aBX.Location = new Point(520, 176);
            aBX.Name = "aBX";
            aBX.Size = new Size(291, 50);
            aBX.TabIndex = 5;
            // 
            // prLB
            // 
            prLB.BackColor = SystemColors.ActiveCaptionText;
            prLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            prLB.ForeColor = Color.Aqua;
            prLB.Location = new Point(328, 444);
            prLB.Name = "prLB";
            prLB.Size = new Size(186, 50);
            prLB.TabIndex = 4;
            prLB.Text = "Price :";
            // 
            // cLB
            // 
            cLB.BackColor = SystemColors.ActiveCaptionText;
            cLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cLB.ForeColor = Color.Aqua;
            cLB.Location = new Point(328, 261);
            cLB.Name = "cLB";
            cLB.Size = new Size(186, 50);
            cLB.TabIndex = 3;
            cLB.Text = "Category :";
            // 
            // pLB
            // 
            pLB.BackColor = Color.Black;
            pLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            pLB.ForeColor = Color.Aqua;
            pLB.Location = new Point(328, 353);
            pLB.Name = "pLB";
            pLB.Size = new Size(186, 50);
            pLB.TabIndex = 2;
            pLB.Text = "Publisher :";
            // 
            // aLB
            // 
            aLB.BackColor = Color.Black;
            aLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            aLB.ForeColor = Color.Aqua;
            aLB.Location = new Point(328, 176);
            aLB.Name = "aLB";
            aLB.Size = new Size(186, 50);
            aLB.TabIndex = 1;
            aLB.Text = "Author :";
            // 
            // mainLB
            // 
            mainLB.BackColor = Color.Black;
            mainLB.Font = new Font("Segoe UI Variable Text", 36F, FontStyle.Bold, GraphicsUnit.Point);
            mainLB.ForeColor = Color.Aqua;
            mainLB.Location = new Point(332, 46);
            mainLB.Name = "mainLB";
            mainLB.Size = new Size(408, 84);
            mainLB.TabIndex = 0;
            mainLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // borrowedBookspanel
            // 
            borrowedBookspanel.Controls.Add(headLB);
            borrowedBookspanel.Controls.Add(borrowedBooksDGV);
            borrowedBookspanel.Dock = DockStyle.Fill;
            borrowedBookspanel.Location = new Point(68, 0);
            borrowedBookspanel.Name = "borrowedBookspanel";
            borrowedBookspanel.Size = new Size(1080, 706);
            borrowedBookspanel.TabIndex = 8;
            // 
            // headLB
            // 
            headLB.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headLB.ForeColor = Color.Aqua;
            headLB.Location = new Point(354, 23);
            headLB.Name = "headLB";
            headLB.Size = new Size(373, 78);
            headLB.TabIndex = 11;
            headLB.Text = "Borrowed Books";
            // 
            // borrowedBooksDGV
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            borrowedBooksDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            borrowedBooksDGV.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            borrowedBooksDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            borrowedBooksDGV.ColumnHeadersHeight = 40;
            borrowedBooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            borrowedBooksDGV.DefaultCellStyle = dataGridViewCellStyle12;
            borrowedBooksDGV.GridColor = Color.FromArgb(231, 229, 255);
            borrowedBooksDGV.Location = new Point(37, 209);
            borrowedBooksDGV.Name = "borrowedBooksDGV";
            borrowedBooksDGV.ReadOnly = true;
            borrowedBooksDGV.RowHeadersVisible = false;
            borrowedBooksDGV.RowHeadersWidth = 51;
            borrowedBooksDGV.RowTemplate.Height = 29;
            borrowedBooksDGV.Size = new Size(1007, 437);
            borrowedBooksDGV.TabIndex = 10;
            borrowedBooksDGV.TabStop = false;
            borrowedBooksDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            borrowedBooksDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            borrowedBooksDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            borrowedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            borrowedBooksDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            borrowedBooksDGV.ThemeStyle.BackColor = Color.DimGray;
            borrowedBooksDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            borrowedBooksDGV.ThemeStyle.HeaderStyle.BackColor = Color.Aqua;
            borrowedBooksDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            borrowedBooksDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            borrowedBooksDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            borrowedBooksDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            borrowedBooksDGV.ThemeStyle.HeaderStyle.Height = 40;
            borrowedBooksDGV.ThemeStyle.ReadOnly = true;
            borrowedBooksDGV.ThemeStyle.RowsStyle.BackColor = Color.Aqua;
            borrowedBooksDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrowedBooksDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            borrowedBooksDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            borrowedBooksDGV.ThemeStyle.RowsStyle.Height = 29;
            borrowedBooksDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            borrowedBooksDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1148, 706);
            Controls.Add(homePanel);
            Controls.Add(userPanel);
            Controls.Add(borrowedBookspanel);
            Controls.Add(updateBookPanel);
            Controls.Add(addBookPanel);
            Controls.Add(sideBar);
            Controls.Add(bookDetails);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            sideBar.ResumeLayout(false);
            logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)List).EndInit();
            homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)booksDGV).EndInit();
            addBookPanel.ResumeLayout(false);
            addBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addedBooksDGV).EndInit();
            updateBookPanel.ResumeLayout(false);
            updateBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updatedBooksDGV).EndInit();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            bookDetails.ResumeLayout(false);
            borrowedBookspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)borrowedBooksDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label categoryLB;
        private FlowLayoutPanel sideBar;
        private FlowLayoutPanel logo;
        private Button Homebtn;
        private Button updateProfileBtn;
        internal Button updateBookbtn;
        private PictureBox List;
        private Label logoLB;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel booksList;
        private Panel homePanel;
        private Guna.UI2.WinForms.Guna2DataGridView booksDGV;
        private Label listLB;
        private Label Title;
        private Panel addBookPanel;
        private Guna.UI2.WinForms.Guna2DataGridView addedBooksDGV;
        private Label label2;
        private Label titleLB;
        private TextBox titleBox;
        private TextBox priceBox;
        private Label priceLB;
        private TextBox publisherBox;
        private Label publisherLB;
        private TextBox ISBNBox;
        private Label ISBNLB;
        private TextBox authorBox;
        private Label authorLB;
        private TextBox categoryBox;
        private Button addBtn;
        private Panel updateBookPanel;
        private Button saveBtn;
        private TextBox addPriceBox;
        private Label addPriceLb;
        private TextBox addPubBox;
        private Label addPubLb;
        private TextBox addAuthorBox;
        private Label addAuthorLb;
        private TextBox addCatBox;
        private Label addCatLb;
        private TextBox addTitleBox;
        private Label addTitleLb;
        private Guna.UI2.WinForms.Guna2DataGridView updatedBooksDGV;
        private Label label8;
        internal Button addBookbtn;
        private Panel userPanel;
        private Label userLB;
        private TextBox passBox;
        private Label userPassLB;
        private TextBox userNameBox;
        private Label userNameLB;
        private Button deleteUserBtn;
        private Button saveUserBtn;
        private Button deleteBookBtn;
        private Panel bookDetails;
        private Label mainLB;
        private Label prLB;
        private Label cLB;
        private Label pLB;
        private Label aLB;
        private Label prBX;
        private Label pBX;
        private Label cBX;
        private Label aBX;
        private Button borrowBtn;
        private Button viewBooksBtn;
        private Panel borrowedBookspanel;
        private Label headLB;
        private Guna.UI2.WinForms.Guna2DataGridView borrowedBooksDGV;
        private Button showPassBtn1;
    }
}