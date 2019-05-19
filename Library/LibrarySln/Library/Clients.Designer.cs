namespace Library
{
    partial class Clients
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
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clientTable = new System.Windows.Forms.DataGridView();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).BeginInit();
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
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(17, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(184, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(17, 97);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(184, 20);
            this.surnameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(17, 155);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(184, 20);
            this.emailBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(17, 214);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(184, 20);
            this.phoneBox.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(17, 254);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(184, 36);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.AddClient);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(17, 296);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteClient);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(126, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // clientTable
            // 
            this.clientTable.AllowUserToResizeColumns = false;
            this.clientTable.AllowUserToResizeRows = false;
            this.clientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientId,
            this.clientName,
            this.clientSurname,
            this.clientEmail,
            this.clientPhone});
            this.clientTable.Location = new System.Drawing.Point(269, 38);
            this.clientTable.Name = "clientTable";
            this.clientTable.Size = new System.Drawing.Size(519, 400);
            this.clientTable.TabIndex = 5;
            this.clientTable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientTable_RowHeaderMouseDoubleClick);
            // 
            // clientId
            // 
            this.clientId.HeaderText = "Id";
            this.clientId.Name = "clientId";
            this.clientId.Visible = false;
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
            // clientEmail
            // 
            this.clientEmail.HeaderText = "Email";
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.ReadOnly = true;
            // 
            // clientPhone
            // 
            this.clientPhone.HeaderText = "Phone";
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.ReadOnly = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientTable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView clientTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhone;
    }
}