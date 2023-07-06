namespace Calculate_Solution
{
    partial class frmCalculator
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.rbnDivide = new System.Windows.Forms.RadioButton();
            this.rbnMultiply = new System.Windows.Forms.RadioButton();
            this.rdnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbnAdd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(78, 51);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(265, 23);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(78, 110);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(265, 23);
            this.txtNum2.TabIndex = 1;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(78, 256);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(265, 23);
            this.txtResults.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(257, 182);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.rbnDivide);
            this.groupBox1.Controls.Add(this.rbnMultiply);
            this.groupBox1.Controls.Add(this.rdnSubtraction);
            this.groupBox1.Controls.Add(this.rbnAdd);
            this.groupBox1.Location = new System.Drawing.Point(454, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(187, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arithmetic Operators";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(28, 245);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 27);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rbnDivide
            // 
            this.rbnDivide.AutoSize = true;
            this.rbnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnDivide.Location = new System.Drawing.Point(38, 173);
            this.rbnDivide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbnDivide.Name = "rbnDivide";
            this.rbnDivide.Size = new System.Drawing.Size(35, 25);
            this.rbnDivide.TabIndex = 3;
            this.rbnDivide.TabStop = true;
            this.rbnDivide.Text = "/";
            this.rbnDivide.UseVisualStyleBackColor = true;
            // 
            // rbnMultiply
            // 
            this.rbnMultiply.AutoSize = true;
            this.rbnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnMultiply.Location = new System.Drawing.Point(38, 119);
            this.rbnMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbnMultiply.Name = "rbnMultiply";
            this.rbnMultiply.Size = new System.Drawing.Size(35, 25);
            this.rbnMultiply.TabIndex = 2;
            this.rbnMultiply.TabStop = true;
            this.rbnMultiply.Text = "*";
            this.rbnMultiply.UseVisualStyleBackColor = true;
            // 
            // rdnSubtraction
            // 
            this.rdnSubtraction.AutoSize = true;
            this.rdnSubtraction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdnSubtraction.Location = new System.Drawing.Point(38, 78);
            this.rdnSubtraction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdnSubtraction.Name = "rdnSubtraction";
            this.rdnSubtraction.Size = new System.Drawing.Size(34, 25);
            this.rdnSubtraction.TabIndex = 1;
            this.rdnSubtraction.TabStop = true;
            this.rdnSubtraction.Text = "-";
            this.rdnSubtraction.UseVisualStyleBackColor = true;
            // 
            // rbnAdd
            // 
            this.rbnAdd.AutoSize = true;
            this.rbnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbnAdd.Location = new System.Drawing.Point(38, 35);
            this.rbnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbnAdd.Name = "rbnAdd";
            this.rbnAdd.Size = new System.Drawing.Size(43, 25);
            this.rbnAdd.TabIndex = 0;
            this.rbnAdd.TabStop = true;
            this.rbnAdd.Text = " +";
            this.rbnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResults);
            this.groupBox2.Controls.Add(this.lblNum2);
            this.groupBox2.Controls.Add(this.lblNum1);
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Controls.Add(this.txtNum1);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.txtNum2);
            this.groupBox2.Location = new System.Drawing.Point(48, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(370, 318);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calc";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(7, 256);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(44, 15);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Results";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(5, 118);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(60, 15);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "Number 2";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(5, 51);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(60, 15);
            this.lblNum1.TabIndex = 4;
            this.lblNum1.Text = "Number 1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 397);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 27);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 397);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 456);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnDivide;
        private System.Windows.Forms.RadioButton rbnMultiply;
        private System.Windows.Forms.RadioButton rdnSubtraction;
        private System.Windows.Forms.RadioButton rbnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}

