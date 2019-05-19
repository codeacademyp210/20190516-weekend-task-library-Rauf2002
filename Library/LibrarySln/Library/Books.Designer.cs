namespace Library
{
    partial class Books
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.authorDrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.bookTable = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(17, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(214, 20);
            this.nameBox.TabIndex = 2;
            // 
            // authorDrop
            // 
            this.authorDrop.FormattingEnabled = true;
            this.authorDrop.Location = new System.Drawing.Point(17, 99);
            this.authorDrop.Name = "authorDrop";
            this.authorDrop.Size = new System.Drawing.Size(214, 21);
            this.authorDrop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(17, 164);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(214, 20);
            this.priceBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // categoryDrop
            // 
            this.categoryDrop.FormattingEnabled = true;
            this.categoryDrop.Location = new System.Drawing.Point(17, 223);
            this.categoryDrop.Name = "categoryDrop";
            this.categoryDrop.Size = new System.Drawing.Size(214, 21);
            this.categoryDrop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(17, 287);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(214, 20);
            this.quantityBox.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(17, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(214, 37);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.AddBook);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(17, 385);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 31);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteCategory);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(146, 385);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(85, 31);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // bookTable
            // 
            this.bookTable.AllowUserToResizeColumns = false;
            this.bookTable.AllowUserToResizeRows = false;
            this.bookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.authorName,
            this.bookPrice,
            this.bookCat,
            this.bookQuantity});
            this.bookTable.Location = new System.Drawing.Point(273, 38);
            this.bookTable.Name = "bookTable";
            this.bookTable.Size = new System.Drawing.Size(515, 378);
            this.bookTable.TabIndex = 13;
            this.bookTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookTable_RowHeaderMouseDoubleClick);
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.Name = "bookId";
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
            // bookCat
            // 
            this.bookCat.HeaderText = "Category";
            this.bookCat.Name = "bookCat";
            this.bookCat.ReadOnly = true;
            // 
            // bookQuantity
            // 
            this.bookQuantity.HeaderText = "Quantity";
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.ReadOnly = true;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookTable);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryDrop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorDrop);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox authorDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryDrop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView bookTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantity;
    }
}