namespace Library
{
    partial class Authors
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.authorTable = new System.Windows.Forms.DataGridView();
            this.authorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.authorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(16, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(228, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(16, 115);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(228, 20);
            this.surnameBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(16, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(228, 34);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.AddAuthor);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(16, 220);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 26);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteAuthor);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetBtn.Location = new System.Drawing.Point(149, 222);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(92, 26);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // authorTable
            // 
            this.authorTable.AllowUserToResizeColumns = false;
            this.authorTable.AllowUserToResizeRows = false;
            this.authorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorId,
            this.authorName,
            this.authorSurname});
            this.authorTable.Location = new System.Drawing.Point(309, 49);
            this.authorTable.Name = "authorTable";
            this.authorTable.Size = new System.Drawing.Size(479, 389);
            this.authorTable.TabIndex = 7;
            this.authorTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AuthorTable_RowHeaderMouseDoubleClick);
            // 
            // authorId
            // 
            this.authorId.HeaderText = "Id";
            this.authorId.Name = "authorId";
            this.authorId.Visible = false;
            // 
            // authorName
            // 
            this.authorName.HeaderText = "Name";
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            // 
            // authorSurname
            // 
            this.authorSurname.HeaderText = "Surname";
            this.authorSurname.Name = "authorSurname";
            this.authorSurname.ReadOnly = true;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorTable);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Author";
            ((System.ComponentModel.ISupportInitialize)(this.authorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView authorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorSurname;
    }
}