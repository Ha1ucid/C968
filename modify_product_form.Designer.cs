using System;

namespace C968_performance_assessment
{
    partial class ModifyProductForm
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
            this.saveButtonModifyProduct = new System.Windows.Forms.Button();
            this.cancelButttonModifyProduct = new System.Windows.Forms.Button();
            this.deleteButtonModifyProduct = new System.Windows.Forms.Button();
            this.searchBoxModifyProduct = new System.Windows.Forms.TextBox();
            this.addButtonModifyProduct = new System.Windows.Forms.Button();
            this.searchButtonModifyProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minInputModifyProduct = new System.Windows.Forms.TextBox();
            this.maxInputModifyProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceInputModifyProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryInputModifyProduct = new System.Windows.Forms.TextBox();
            this.nameInputModifyProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idModifyProduct = new System.Windows.Forms.Label();
            this.partDataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButtonModifyProduct
            // 
            this.saveButtonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButtonModifyProduct.Location = new System.Drawing.Point(926, 610);
            this.saveButtonModifyProduct.Name = "saveButtonModifyProduct";
            this.saveButtonModifyProduct.Size = new System.Drawing.Size(55, 23);
            this.saveButtonModifyProduct.TabIndex = 62;
            this.saveButtonModifyProduct.Text = "Save";
            this.saveButtonModifyProduct.UseVisualStyleBackColor = true;
            this.saveButtonModifyProduct.Click += new System.EventHandler(this.SaveButtonModifyProduct_Click);
            // 
            // cancelButttonModifyProduct
            // 
            this.cancelButttonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButttonModifyProduct.Location = new System.Drawing.Point(997, 610);
            this.cancelButttonModifyProduct.Name = "cancelButttonModifyProduct";
            this.cancelButttonModifyProduct.Size = new System.Drawing.Size(55, 23);
            this.cancelButttonModifyProduct.TabIndex = 61;
            this.cancelButttonModifyProduct.Text = "Cancel";
            this.cancelButttonModifyProduct.UseVisualStyleBackColor = true;
            this.cancelButttonModifyProduct.Click += new System.EventHandler(this.CancelButttonModifyProduct_Click);
            // 
            // deleteButtonModifyProduct
            // 
            this.deleteButtonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonModifyProduct.Location = new System.Drawing.Point(997, 566);
            this.deleteButtonModifyProduct.Name = "deleteButtonModifyProduct";
            this.deleteButtonModifyProduct.Size = new System.Drawing.Size(55, 23);
            this.deleteButtonModifyProduct.TabIndex = 60;
            this.deleteButtonModifyProduct.Text = "Delete";
            this.deleteButtonModifyProduct.UseVisualStyleBackColor = true;
            this.deleteButtonModifyProduct.Click += new System.EventHandler(this.DeleteButtonModifyProduct_Click);
            // 
            // searchBoxModifyProduct
            // 
            this.searchBoxModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBoxModifyProduct.Location = new System.Drawing.Point(926, 87);
            this.searchBoxModifyProduct.Name = "searchBoxModifyProduct";
            this.searchBoxModifyProduct.Size = new System.Drawing.Size(148, 20);
            this.searchBoxModifyProduct.TabIndex = 59;
            // 
            // addButtonModifyProduct
            // 
            this.addButtonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButtonModifyProduct.Location = new System.Drawing.Point(997, 319);
            this.addButtonModifyProduct.Name = "addButtonModifyProduct";
            this.addButtonModifyProduct.Size = new System.Drawing.Size(55, 23);
            this.addButtonModifyProduct.TabIndex = 58;
            this.addButtonModifyProduct.Text = "Add";
            this.addButtonModifyProduct.UseVisualStyleBackColor = true;
            this.addButtonModifyProduct.Click += new System.EventHandler(this.AddButtonModifyProduct_Click);
            // 
            // searchButtonModifyProduct
            // 
            this.searchButtonModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButtonModifyProduct.Location = new System.Drawing.Point(845, 84);
            this.searchButtonModifyProduct.Name = "searchButtonModifyProduct";
            this.searchButtonModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.searchButtonModifyProduct.TabIndex = 57;
            this.searchButtonModifyProduct.Text = "Search";
            this.searchButtonModifyProduct.UseVisualStyleBackColor = true;
            this.searchButtonModifyProduct.Click += new System.EventHandler(this.SearchButtonModifyProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(430, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(430, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "All Candidate Parts";
            // 
            // minInputModifyProduct
            // 
            this.minInputModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minInputModifyProduct.Location = new System.Drawing.Point(225, 316);
            this.minInputModifyProduct.Name = "minInputModifyProduct";
            this.minInputModifyProduct.Size = new System.Drawing.Size(60, 20);
            this.minInputModifyProduct.TabIndex = 52;
            // 
            // maxInputModifyProduct
            // 
            this.maxInputModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxInputModifyProduct.Location = new System.Drawing.Point(94, 316);
            this.maxInputModifyProduct.Name = "maxInputModifyProduct";
            this.maxInputModifyProduct.Size = new System.Drawing.Size(60, 20);
            this.maxInputModifyProduct.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(41, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(177, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Min";
            // 
            // priceInputModifyProduct
            // 
            this.priceInputModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceInputModifyProduct.Location = new System.Drawing.Point(131, 277);
            this.priceInputModifyProduct.Name = "priceInputModifyProduct";
            this.priceInputModifyProduct.Size = new System.Drawing.Size(100, 20);
            this.priceInputModifyProduct.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(41, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Price";
            // 
            // inventoryInputModifyProduct
            // 
            this.inventoryInputModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryInputModifyProduct.Location = new System.Drawing.Point(131, 235);
            this.inventoryInputModifyProduct.Name = "inventoryInputModifyProduct";
            this.inventoryInputModifyProduct.Size = new System.Drawing.Size(100, 20);
            this.inventoryInputModifyProduct.TabIndex = 46;
            // 
            // nameInputModifyProduct
            // 
            this.nameInputModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInputModifyProduct.Location = new System.Drawing.Point(131, 191);
            this.nameInputModifyProduct.Name = "nameInputModifyProduct";
            this.nameInputModifyProduct.Size = new System.Drawing.Size(100, 20);
            this.nameInputModifyProduct.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(40, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Modify Product";
            // 
            // idModifyProduct
            // 
            this.idModifyProduct.AutoSize = true;
            this.idModifyProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idModifyProduct.Location = new System.Drawing.Point(131, 154);
            this.idModifyProduct.Name = "idModifyProduct";
            this.idModifyProduct.Size = new System.Drawing.Size(56, 19);
            this.idModifyProduct.TabIndex = 63;
            this.idModifyProduct.Text = "label10";
            // 
            // partDataGridView1
            // 
            this.partDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView1.Location = new System.Drawing.Point(433, 122);
            this.partDataGridView1.MultiSelect = false;
            this.partDataGridView1.Name = "partDataGridView1";
            this.partDataGridView1.ReadOnly = true;
            this.partDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView1.Size = new System.Drawing.Size(641, 191);
            this.partDataGridView1.TabIndex = 65;
            // 
            // productDataGridView2
            // 
            this.productDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView2.Location = new System.Drawing.Point(433, 369);
            this.productDataGridView2.MultiSelect = false;
            this.productDataGridView2.Name = "productDataGridView2";
            this.productDataGridView2.ReadOnly = true;
            this.productDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView2.Size = new System.Drawing.Size(641, 191);
            this.productDataGridView2.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(44, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 17);
            this.label10.TabIndex = 67;
            this.label10.Text = "Min value cannot be greater than max value.";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(248, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 68);
            this.label11.TabIndex = 68;
            this.label11.Text = "Inventory value cannot\r\nbe greater than max\r\nvalue or less than min\r\nvalue.";
            this.label11.Visible = false;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 681);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productDataGridView2);
            this.Controls.Add(this.partDataGridView1);
            this.Controls.Add(this.idModifyProduct);
            this.Controls.Add(this.saveButtonModifyProduct);
            this.Controls.Add(this.cancelButttonModifyProduct);
            this.Controls.Add(this.deleteButtonModifyProduct);
            this.Controls.Add(this.searchBoxModifyProduct);
            this.Controls.Add(this.addButtonModifyProduct);
            this.Controls.Add(this.searchButtonModifyProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minInputModifyProduct);
            this.Controls.Add(this.maxInputModifyProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceInputModifyProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryInputModifyProduct);
            this.Controls.Add(this.nameInputModifyProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProductForm";
            this.Text = "modify_product_form";
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButtonModifyProduct;
        private System.Windows.Forms.Button cancelButttonModifyProduct;
        private System.Windows.Forms.Button deleteButtonModifyProduct;
        private System.Windows.Forms.TextBox searchBoxModifyProduct;
        private System.Windows.Forms.Button addButtonModifyProduct;
        private System.Windows.Forms.Button searchButtonModifyProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minInputModifyProduct;
        private System.Windows.Forms.TextBox maxInputModifyProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceInputModifyProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventoryInputModifyProduct;
        private System.Windows.Forms.TextBox nameInputModifyProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idModifyProduct;
        private System.Windows.Forms.DataGridView partDataGridView1;
        private System.Windows.Forms.DataGridView productDataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}