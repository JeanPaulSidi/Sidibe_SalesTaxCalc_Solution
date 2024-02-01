namespace Sidibe_SalesTaxCalc_Project
{
    partial class MainForm
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtPriceInput = new System.Windows.Forms.TextBox();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.cboWarrantyChoice = new System.Windows.Forms.ComboBox();
            this.lblStateSold = new System.Windows.Forms.Label();
            this.cboStateSoldChoice = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(13, 13);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(770, 92);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Billy Bob\'s Vehicle Sales Tax Calculator\r\n\r\n";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(37, 128);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(281, 36);
            this.lblBasePrice.TabIndex = 1;
            this.lblBasePrice.Text = "Vehicle Base Price :";
            // 
            // txtPriceInput
            // 
            this.txtPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceInput.Location = new System.Drawing.Point(313, 125);
            this.txtPriceInput.Name = "txtPriceInput";
            this.txtPriceInput.Size = new System.Drawing.Size(292, 41);
            this.txtPriceInput.TabIndex = 3;
            this.txtPriceInput.TextChanged += new System.EventHandler(this.txtPriceInput_TextChanged);
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(32, 211);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(286, 36);
            this.lblWarranty.TabIndex = 4;
            this.lblWarranty.Text = "Extended Warranty :";
            // 
            // cboWarrantyChoice
            // 
            this.cboWarrantyChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarrantyChoice.FormattingEnabled = true;
            this.cboWarrantyChoice.Items.AddRange(new object[] {
            "No Warranty",
            "One Year",
            "Two Years",
            "Three Years"});
            this.cboWarrantyChoice.Location = new System.Drawing.Point(313, 203);
            this.cboWarrantyChoice.Name = "cboWarrantyChoice";
            this.cboWarrantyChoice.Size = new System.Drawing.Size(292, 44);
            this.cboWarrantyChoice.TabIndex = 5;
            // 
            // lblStateSold
            // 
            this.lblStateSold.AutoSize = true;
            this.lblStateSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateSold.Location = new System.Drawing.Point(147, 297);
            this.lblStateSold.Name = "lblStateSold";
            this.lblStateSold.Size = new System.Drawing.Size(160, 36);
            this.lblStateSold.TabIndex = 6;
            this.lblStateSold.Text = "Sate Sold :";
            // 
            // cboStateSoldChoice
            // 
            this.cboStateSoldChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStateSoldChoice.FormattingEnabled = true;
            this.cboStateSoldChoice.Items.AddRange(new object[] {
            "OR",
            "WA"});
            this.cboStateSoldChoice.Location = new System.Drawing.Point(313, 289);
            this.cboStateSoldChoice.Name = "cboStateSoldChoice";
            this.cboStateSoldChoice.Size = new System.Drawing.Size(93, 44);
            this.cboStateSoldChoice.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(476, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 55);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(147, 396);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 36);
            this.lblTotalCost.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(404, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 53);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(583, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboStateSoldChoice);
            this.Controls.Add(this.lblStateSold);
            this.Controls.Add(this.cboWarrantyChoice);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.txtPriceInput);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblAppName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtPriceInput;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.ComboBox cboWarrantyChoice;
        private System.Windows.Forms.Label lblStateSold;
        private System.Windows.Forms.ComboBox cboStateSoldChoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

