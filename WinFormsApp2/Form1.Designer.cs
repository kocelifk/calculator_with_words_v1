
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.lblLang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lngComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(74, 85);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(44, 15);
            this.lblVal1.TabIndex = 0;
            this.lblVal1.Text = "Value 1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(74, 126);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(44, 15);
            this.lblVal2.TabIndex = 1;
            this.lblVal2.Text = "Value 2";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(74, 289);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(39, 15);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "Result";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(156, 77);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 23);
            this.txtValue1.TabIndex = 3;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(156, 126);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 23);
            this.txtValue2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(156, 286);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(237, 23);
            this.txtResult.TabIndex = 5;
            // 
            // btn_Addition
            // 
            this.btn_Addition.Location = new System.Drawing.Point(74, 228);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(75, 23);
            this.btn_Addition.TabIndex = 6;
            this.btn_Addition.Text = "+";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.btn_Addition_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Location = new System.Drawing.Point(156, 228);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubstraction.TabIndex = 7;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(237, 228);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(75, 23);
            this.btn_Division.TabIndex = 8;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Location = new System.Drawing.Point(318, 228);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiplication.TabIndex = 9;
            this.btn_Multiplication.Text = "x";
            this.btn_Multiplication.UseVisualStyleBackColor = true;
            this.btn_Multiplication.Click += new System.EventHandler(this.btn_Multiplication_Click);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(482, 9);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(59, 15);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 11;
            // 
            // lngComboBox
            // 
            this.lngComboBox.FormattingEnabled = true;
            this.lngComboBox.Location = new System.Drawing.Point(549, 6);
            this.lngComboBox.Name = "lngComboBox";
            this.lngComboBox.Size = new System.Drawing.Size(80, 23);
            this.lngComboBox.TabIndex = 12;
            this.lngComboBox.SelectedIndexChanged += new System.EventHandler(this.lngComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 389);
            this.Controls.Add(this.lngComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lngComboBox;
    }
}

