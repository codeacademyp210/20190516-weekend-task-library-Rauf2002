namespace Library
{
    partial class LibraryForm
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
            this.bookTable = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.bookBox = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookTable
            // 
            this.bookTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.authorName,
            this.bookPrice,
            this.bookQuantity,
            this.bookCategory});
            this.bookTable.Location = new System.Drawing.Point(458, 115);
            this.bookTable.Name = "bookTable";
            this.bookTable.Size = new System.Drawing.Size(489, 491);
            this.bookTable.TabIndex = 0;
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Visible = false;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // authorName
            // 
            this.authorName.HeaderText = "Author";
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            // 
            // bookPrice
            // 
            this.bookPrice.HeaderText = "Price";
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.ReadOnly = true;
            // 
            // bookQuantity
            // 
            this.bookQuantity.HeaderText = "Quantity";
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.ReadOnly = true;
            // 
            // bookCategory
            // 
            this.bookCategory.HeaderText = "Category";
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.ReadOnly = true;
            // 
            // userTable
            // 
            this.userTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clientName,
            this.clientSurname,
            this.clientPhone,
            this.clientEmail});
            this.userTable.Location = new System.Drawing.Point(17, 115);
            this.userTable.Name = "userTable";
            this.userTable.Size = new System.Drawing.Size(434, 491);
            this.userTable.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // clientName
            // 
            this.clientName.HeaderText = "Name";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            // 
            // clientSurname
            // 
            this.clientSurname.HeaderText = "Surname";
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.ReadOnly = true;
            // 
            // clientPhone
            // 
            this.clientPhone.HeaderText = "Phone";
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.ReadOnly = true;
            // 
            // clientEmail
            // 
            this.clientEmail.HeaderText = "Email";
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(670, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(40, 72);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(391, 20);
            this.UserBox.TabIndex = 1;
            this.UserBox.TextChanged += new System.EventHandler(this.SearchUser);
            // 
            // bookBox
            // 
            this.bookBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBox.Location = new System.Drawing.Point(495, 68);
            this.bookBox.Name = "bookBox";
            this.bookBox.Size = new System.Drawing.Size(407, 20);
            this.bookBox.TabIndex = 2;
            this.bookBox.TextChanged += new System.EventHandler(this.SearchBook);
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderBtn.Location = new System.Drawing.Point(17, 612);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(434, 37);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookToolStripMenuItem.Text = "Books";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.BookToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.AuthorsToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.CreateCategory);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(807, 612);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(140, 37);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 676);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.bookBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.bookTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookTable;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox bookBox;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmail;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategory;
    }
}

