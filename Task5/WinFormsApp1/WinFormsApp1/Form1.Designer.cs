namespace WinFormsApp1
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
            txtInpt1 = new TextBox();
            btnPlus = new Button();
            btnDivision = new Button();
            btnMinus = new Button();
            btnMultiplication = new Button();
            lblOutput = new Label();
            btnPoint = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btnC = new Button();
            btnE = new Button();
            SuspendLayout();
            // 
            // txtInpt1
            // 
            txtInpt1.Location = new Point(7, 9);
            txtInpt1.Name = "txtInpt1";
            txtInpt1.Size = new Size(93, 23);
            txtInpt1.TabIndex = 1;
            txtInpt1.TextChanged += txtInpt1_TextChanged;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(106, 128);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(27, 24);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button1_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(106, 68);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(27, 24);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(106, 98);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(27, 24);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(106, 38);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(27, 24);
            btnMultiplication.TabIndex = 7;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(315, 99);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 8;
            lblOutput.Click += lblOutput_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(73, 128);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(27, 24);
            btnPoint.TabIndex = 9;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += button1_Click_1;
            // 
            // btn0
            // 
            btn0.Location = new Point(40, 128);
            btn0.Name = "btn0";
            btn0.Size = new Size(27, 24);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(40, 98);
            btn8.Name = "btn8";
            btn8.Size = new Size(27, 24);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button1_Click_2;
            // 
            // btn9
            // 
            btn9.Location = new Point(73, 98);
            btn9.Name = "btn9";
            btn9.Size = new Size(27, 24);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(73, 68);
            btn6.Name = "btn6";
            btn6.Size = new Size(27, 24);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(40, 68);
            btn5.Name = "btn5";
            btn5.Size = new Size(27, 24);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(7, 98);
            btn7.Name = "btn7";
            btn7.Size = new Size(27, 24);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(7, 68);
            btn4.Name = "btn4";
            btn4.Size = new Size(27, 24);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(40, 38);
            btn2.Name = "btn2";
            btn2.Size = new Size(27, 24);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(73, 38);
            btn3.Name = "btn3";
            btn3.Size = new Size(27, 24);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(7, 38);
            btn1.Name = "btn1";
            btn1.Size = new Size(27, 24);
            btn1.TabIndex = 19;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(7, 128);
            btnC.Name = "btnC";
            btnC.Size = new Size(27, 24);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnE
            // 
            btnE.Location = new Point(106, 8);
            btnE.Name = "btnE";
            btnE.Size = new Size(27, 24);
            btnE.TabIndex = 21;
            btnE.Text = "=";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(141, 160);
            Controls.Add(btnE);
            Controls.Add(btnC);
            Controls.Add(btn1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btnPoint);
            Controls.Add(lblOutput);
            Controls.Add(btnMultiplication);
            Controls.Add(btnMinus);
            Controls.Add(btnDivision);
            Controls.Add(btnPlus);
            Controls.Add(txtInpt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInpt1;
        private Button btnPlus;
        private Button btnDivision;
        private Button btnMinus;
        private Button btnMultiplication;
        private Label lblOutput;
        private Button btnPoint;
        private Button btn0;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn7;
        private Button btn4;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btnC;
        private Button btnE;
    }
}