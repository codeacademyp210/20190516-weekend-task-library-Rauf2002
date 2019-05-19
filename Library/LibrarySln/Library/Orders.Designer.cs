namespace Library
{
    partial class Orders
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
            this.orderBox = new System.Windows.Forms.TextBox();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBox
            // 
            this.orderBox.Location = new System.Drawing.Point(123, 12);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(571, 20);
            this.orderBox.TabIndex = 0;
            this.orderBox.TextChanged += new System.EventHandler(this.SearchOrder);
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToOrderColumns = true;
            this.ordersTable.AllowUserToResizeColumns = false;
            this.ordersTable.AllowUserToResizeRows = false;
            this.ordersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.clientFull,
            this.authorFull,
            this.orderDate,
            this.returnDate});
            this.ordersTable.Location = new System.Drawing.Point(13, 42);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.Size = new System.Drawing.Size(775, 396);
            this.ordersTable.TabIndex = 1;
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Id";
            this.orderId.Name = "orderId";
            this.orderId.Visible = false;
            // 
            // clientFull
            // 
            this.clientFull.HeaderText = "Client ";
            this.clientFull.Name = "clientFull";
            this.clientFull.ReadOnly = true;
            // 
            // authorFull
            // 
            this.authorFull.HeaderText = "Author ";
            this.authorFull.Name = "authorFull";
            this.authorFull.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // returnDate
            // 
            this.returnDate.HeaderText = "Return Date";
            this.returnDate.Name = "returnDate";
            this.returnDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersTable);
            this.Controls.Add(this.orderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderBox;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.Label label1;
    }
}