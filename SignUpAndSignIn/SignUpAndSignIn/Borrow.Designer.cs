namespace SignUpAndSignIn
{
    partial class Borrow
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtAccessionNumber = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.txtBorrowerAddress = new System.Windows.Forms.TextBox();
            this.txtBorrowerContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(121, 346);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "BORROW";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtAccessionNumber
            // 
            this.txtAccessionNumber.Location = new System.Drawing.Point(234, 110);
            this.txtAccessionNumber.Name = "txtAccessionNumber";
            this.txtAccessionNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccessionNumber.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(234, 150);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(234, 189);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerName.TabIndex = 3;
            // 
            // txtBorrowerAddress
            // 
            this.txtBorrowerAddress.Location = new System.Drawing.Point(234, 232);
            this.txtBorrowerAddress.Name = "txtBorrowerAddress";
            this.txtBorrowerAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerAddress.TabIndex = 4;
            // 
            // txtBorrowerContactNumber
            // 
            this.txtBorrowerContactNumber.Location = new System.Drawing.Point(234, 271);
            this.txtBorrowerContactNumber.Name = "txtBorrowerContactNumber";
            this.txtBorrowerContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerContactNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Accession Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact No.";
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBorrowerContactNumber);
            this.Controls.Add(this.txtBorrowerAddress);
            this.Controls.Add(this.txtBorrowerName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAccessionNumber);
            this.Controls.Add(this.btnBorrow);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtAccessionNumber;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBorrowerName;
        private System.Windows.Forms.TextBox txtBorrowerAddress;
        private System.Windows.Forms.TextBox txtBorrowerContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}