﻿namespace basic_calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 15);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(236, 20);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(62, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(62, 79);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 31);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(98, 79);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 31);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(136, 79);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 31);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(174, 79);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 31);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(210, 79);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(38, 31);
            this.btnSqrt.TabIndex = 7;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(210, 116);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(38, 31);
            this.btnReciprocal.TabIndex = 12;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(174, 116);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(30, 31);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(136, 116);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 31);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(98, 116);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 31);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(62, 116);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 31);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(210, 153);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(38, 68);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(174, 153);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(30, 31);
            this.btnSub.TabIndex = 16;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(136, 153);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 31);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(98, 153);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 31);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(62, 153);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 31);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 31);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(136, 190);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(32, 31);
            this.btnDecimal.TabIndex = 20;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(98, 190);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(31, 31);
            this.btnSign.TabIndex = 19;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(62, 190);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(30, 31);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(18, 116);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(38, 31);
            this.btnMR.TabIndex = 23;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(18, 79);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(38, 31);
            this.btnMC.TabIndex = 22;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Location = new System.Drawing.Point(18, 190);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(38, 31);
            this.btnMPlus.TabIndex = 25;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btn_Handler);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(18, 153);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(38, 31);
            this.btnMS.TabIndex = 24;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btn_Handler);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Label label1;
    }
}

