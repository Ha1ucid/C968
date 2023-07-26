namespace C968_performance_assessment
{
    partial class MainScreenForm
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
            this.searchButtonMain1 = new System.Windows.Forms.Button();
            this.searchButtonMain2 = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deleteButtonPart = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteButtonProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBoxMain1 = new System.Windows.Forms.TextBox();
            this.searchBoxMain2 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment System";
            // 
            // searchButtonMain1
            // 
            this.searchButtonMain1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButtonMain1.Location = new System.Drawing.Point(363, 86);
            this.searchButtonMain1.Name = "searchButtonMain1";
            this.searchButtonMain1.Size = new System.Drawing.Size(55, 23);
            this.searchButtonMain1.TabIndex = 3;
            this.searchButtonMain1.Text = "Search";
            this.searchButtonMain1.UseVisualStyleBackColor = true;
            this.searchButtonMain1.Click += new System.EventHandler(this.SearchButtonMain1_Click);
            // 
            // searchButtonMain2
            // 
            this.searchButtonMain2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButtonMain2.Location = new System.Drawing.Point(1067, 86);
            this.searchButtonMain2.Name = "searchButtonMain2";
            this.searchButtonMain2.Size = new System.Drawing.Size(55, 23);
            this.searchButtonMain2.TabIndex = 4;
            this.searchButtonMain2.Text = "Search";
            this.searchButtonMain2.UseVisualStyleBackColor = true;
            this.searchButtonMain2.Click += new System.EventHandler(this.SearchButtonMain2_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPartButton.Location = new System.Drawing.Point(497, 362);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(55, 23);
            this.addPartButton.TabIndex = 5;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyPartButton.Location = new System.Drawing.Point(558, 362);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(55, 23);
            this.modifyPartButton.TabIndex = 6;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // deleteButtonPart
            // 
            this.deleteButtonPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonPart.Location = new System.Drawing.Point(619, 362);
            this.deleteButtonPart.Name = "deleteButtonPart";
            this.deleteButtonPart.Size = new System.Drawing.Size(55, 23);
            this.deleteButtonPart.TabIndex = 7;
            this.deleteButtonPart.Text = "Delete";
            this.deleteButtonPart.UseVisualStyleBackColor = true;
            this.deleteButtonPart.Click += new System.EventHandler(this.DeleteButtonPart_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductButton.Location = new System.Drawing.Point(1201, 362);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(55, 23);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyProductButton.Location = new System.Drawing.Point(1262, 362);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(55, 23);
            this.modifyProductButton.TabIndex = 9;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.ModifyProductsButton_Click);
            // 
            // deleteButtonProduct
            // 
            this.deleteButtonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonProduct.Location = new System.Drawing.Point(1323, 362);
            this.deleteButtonProduct.Name = "deleteButtonProduct";
            this.deleteButtonProduct.Size = new System.Drawing.Size(55, 23);
            this.deleteButtonProduct.TabIndex = 10;
            this.deleteButtonProduct.Text = "Delete";
            this.deleteButtonProduct.UseVisualStyleBackColor = true;
            this.deleteButtonProduct.Click += new System.EventHandler(this.DeleteButtonProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(738, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parts";
            // 
            // searchBoxMain1
            // 
            this.searchBoxMain1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBoxMain1.Location = new System.Drawing.Point(424, 89);
            this.searchBoxMain1.Name = "searchBoxMain1";
            this.searchBoxMain1.Size = new System.Drawing.Size(250, 20);
            this.searchBoxMain1.TabIndex = 13;
            // 
            // searchBoxMain2
            // 
            this.searchBoxMain2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBoxMain2.Location = new System.Drawing.Point(1128, 89);
            this.searchBoxMain2.Name = "searchBoxMain2";
            this.searchBoxMain2.Size = new System.Drawing.Size(250, 20);
            this.searchBoxMain2.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(1323, 414);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToResizeColumns = false;
            this.partDataGridView.AllowUserToResizeRows = false;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.Location = new System.Drawing.Point(31, 115);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.ReadOnly = true;
            this.partDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(643, 220);
            this.partDataGridView.TabIndex = 15;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(733, 115);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(645, 220);
            this.productDataGridView.TabIndex = 15;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 468);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.partDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchBoxMain2);
            this.Controls.Add(this.searchBoxMain1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButtonProduct);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteButtonPart);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.searchButtonMain2);
            this.Controls.Add(this.searchButtonMain1);
            this.Controls.Add(this.label1);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButtonMain1;
        private System.Windows.Forms.Button searchButtonMain2;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deleteButtonPart;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteButtonProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBoxMain1;
        private System.Windows.Forms.TextBox searchBoxMain2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridView partDataGridView;
    }
}

