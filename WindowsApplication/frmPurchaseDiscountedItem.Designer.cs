namespace WindowsApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(58, 84);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(292, 34);
            this.txtItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(136, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(214, 34);
            this.txtPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount(%):";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(411, 84);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(339, 34);
            this.txtDiscount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(524, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(226, 34);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(279, 211);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(159, 34);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(225, 274);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(53, 20);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment received:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(269, 340);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(203, 34);
            this.txtAmountPaid.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(481, 340);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 34);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(265, 400);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(53, 20);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Change:";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 469);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "frmPurchaseDiscountedItem";
            this.Load += new System.EventHandler(this.frmPurchaseDiscountedItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label9;
    }
}