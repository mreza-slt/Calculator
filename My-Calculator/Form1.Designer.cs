namespace My_Calculator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultyple = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد دوم :";
            // 
            // txtNumber1
            // 
            this.txtNumber1.AccessibleName = "txt-number1";
            this.txtNumber1.Location = new System.Drawing.Point(12, 20);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(302, 23);
            this.txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            this.txtNumber2.AccessibleName = "txt-number2";
            this.txtNumber2.Location = new System.Drawing.Point(12, 56);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(301, 23);
            this.txtNumber2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(33, 85);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 28);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(101, 84);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 28);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultyple
            // 
            this.btnMultyple.Location = new System.Drawing.Point(169, 85);
            this.btnMultyple.Name = "btnMultyple";
            this.btnMultyple.Size = new System.Drawing.Size(62, 28);
            this.btnMultyple.TabIndex = 6;
            this.btnMultyple.Text = "*";
            this.btnMultyple.UseVisualStyleBackColor = true;
            this.btnMultyple.Click += new System.EventHandler(this.btnMultyple_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(237, 84);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(62, 28);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 131);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultyple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNumber1;
        private System.Windows.Forms.NumericUpDown txtNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultyple;
        private System.Windows.Forms.Button btnDivide;
    }
}

