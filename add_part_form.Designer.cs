namespace C968_performance_assessment
{
    partial class AddPartForm
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
            this.inHouseRadioAddPart = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioAddPart = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.idInputAddPart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInputAddPart = new System.Windows.Forms.TextBox();
            this.inventoryInputAddPart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceInputAddPart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxInputAddPart = new System.Windows.Forms.TextBox();
            this.minInputAddPart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.machineCompanyInputAddPart = new System.Windows.Forms.TextBox();
            this.savePartButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouseRadioAddPart
            // 
            this.inHouseRadioAddPart.AutoSize = true;
            this.inHouseRadioAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inHouseRadioAddPart.Location = new System.Drawing.Point(139, 8);
            this.inHouseRadioAddPart.Name = "inHouseRadioAddPart";
            this.inHouseRadioAddPart.Size = new System.Drawing.Size(83, 21);
            this.inHouseRadioAddPart.TabIndex = 1;
            this.inHouseRadioAddPart.TabStop = true;
            this.inHouseRadioAddPart.Text = "In-House";
            this.inHouseRadioAddPart.UseVisualStyleBackColor = true;
            this.inHouseRadioAddPart.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            this.inHouseRadioAddPart.Click += new System.EventHandler(this.InHouseRadioButton_Click);
            // 
            // outsourcedRadioAddPart
            // 
            this.outsourcedRadioAddPart.AutoSize = true;
            this.outsourcedRadioAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outsourcedRadioAddPart.Location = new System.Drawing.Point(268, 10);
            this.outsourcedRadioAddPart.Name = "outsourcedRadioAddPart";
            this.outsourcedRadioAddPart.Size = new System.Drawing.Size(100, 21);
            this.outsourcedRadioAddPart.TabIndex = 2;
            this.outsourcedRadioAddPart.TabStop = true;
            this.outsourcedRadioAddPart.Text = "Outsourced";
            this.outsourcedRadioAddPart.UseVisualStyleBackColor = true;
            this.outsourcedRadioAddPart.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            this.outsourcedRadioAddPart.Click += new System.EventHandler(this.OutsourcedRadioButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(136, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // idInputAddPart
            // 
            this.idInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idInputAddPart.Location = new System.Drawing.Point(174, 67);
            this.idInputAddPart.Name = "idInputAddPart";
            this.idInputAddPart.Size = new System.Drawing.Size(100, 20);
            this.idInputAddPart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(112, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(91, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inventory";
            // 
            // nameInputAddPart
            // 
            this.nameInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInputAddPart.Location = new System.Drawing.Point(174, 107);
            this.nameInputAddPart.Name = "nameInputAddPart";
            this.nameInputAddPart.Size = new System.Drawing.Size(100, 20);
            this.nameInputAddPart.TabIndex = 7;
            // 
            // inventoryInputAddPart
            // 
            this.inventoryInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryInputAddPart.Location = new System.Drawing.Point(174, 150);
            this.inventoryInputAddPart.Name = "inventoryInputAddPart";
            this.inventoryInputAddPart.Size = new System.Drawing.Size(100, 20);
            this.inventoryInputAddPart.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(77, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price / Cost";
            // 
            // priceInputAddPart
            // 
            this.priceInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceInputAddPart.Location = new System.Drawing.Point(174, 190);
            this.priceInputAddPart.Name = "priceInputAddPart";
            this.priceInputAddPart.Size = new System.Drawing.Size(100, 20);
            this.priceInputAddPart.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(253, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(124, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max";
            // 
            // maxInputAddPart
            // 
            this.maxInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxInputAddPart.Location = new System.Drawing.Point(174, 229);
            this.maxInputAddPart.Name = "maxInputAddPart";
            this.maxInputAddPart.Size = new System.Drawing.Size(60, 20);
            this.maxInputAddPart.TabIndex = 13;
            // 
            // minInputAddPart
            // 
            this.minInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minInputAddPart.Location = new System.Drawing.Point(302, 229);
            this.minInputAddPart.Name = "minInputAddPart";
            this.minInputAddPart.Size = new System.Drawing.Size(60, 20);
            this.minInputAddPart.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(77, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 15;
            // 
            // machineCompanyInputAddPart
            // 
            this.machineCompanyInputAddPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineCompanyInputAddPart.Location = new System.Drawing.Point(174, 267);
            this.machineCompanyInputAddPart.Name = "machineCompanyInputAddPart";
            this.machineCompanyInputAddPart.Size = new System.Drawing.Size(100, 20);
            this.machineCompanyInputAddPart.TabIndex = 16;
            // 
            // savePartButton
            // 
            this.savePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savePartButton.Location = new System.Drawing.Point(295, 334);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(55, 23);
            this.savePartButton.TabIndex = 17;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(361, 334);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(55, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(48, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(12, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 68);
            this.label10.TabIndex = 20;
            this.label10.Text = "Min value \r\ncannot be \r\ngreater than \r\nmax value.";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(292, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 68);
            this.label11.TabIndex = 21;
            this.label11.Text = "Inventory value \r\ncannot be greaer \r\nthan max value or \r\nless than min value";
            this.label11.Visible = false;
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 383);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.machineCompanyInputAddPart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minInputAddPart);
            this.Controls.Add(this.maxInputAddPart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceInputAddPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryInputAddPart);
            this.Controls.Add(this.nameInputAddPart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idInputAddPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outsourcedRadioAddPart);
            this.Controls.Add(this.inHouseRadioAddPart);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseRadioAddPart;
        private System.Windows.Forms.RadioButton outsourcedRadioAddPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idInputAddPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInputAddPart;
        private System.Windows.Forms.TextBox inventoryInputAddPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceInputAddPart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxInputAddPart;
        private System.Windows.Forms.TextBox minInputAddPart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox machineCompanyInputAddPart;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}