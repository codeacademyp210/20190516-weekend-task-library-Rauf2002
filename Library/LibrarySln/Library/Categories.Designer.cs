namespace Library
{
    partial class Categories
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
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.categoryTable = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(16, 57);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(309, 20);
            this.categoryBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(16, 98);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(309, 37);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.AddCategory);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(16, 142);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(146, 32);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteCategory);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(191, 141);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(134, 33);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // categoryTable
            // 
            this.categoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.categoryName});
            this.categoryTable.Location = new System.Drawing.Point(351, 57);
            this.categoryTable.Name = "categoryTable";
            this.categoryTable.Size = new System.Drawing.Size(437, 381);
            this.categoryTable.TabIndex = 5;
            this.categoryTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CategoryTable_RowHeaderMouseDoubleClick);
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "Id";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryTable);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView categoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    }
}