
namespace winRPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stackBox2 = new System.Windows.Forms.TextBox();
            this.stackBox1 = new System.Windows.Forms.TextBox();
            this.stackBox0 = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackBox2
            // 
            this.stackBox2.Location = new System.Drawing.Point(63, 16);
            this.stackBox2.Name = "stackBox2";
            this.stackBox2.ReadOnly = true;
            this.stackBox2.Size = new System.Drawing.Size(100, 23);
            this.stackBox2.TabIndex = 0;
            this.stackBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stackBox1
            // 
            this.stackBox1.Location = new System.Drawing.Point(63, 46);
            this.stackBox1.Name = "stackBox1";
            this.stackBox1.ReadOnly = true;
            this.stackBox1.Size = new System.Drawing.Size(100, 23);
            this.stackBox1.TabIndex = 1;
            this.stackBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stackBox0
            // 
            this.stackBox0.Location = new System.Drawing.Point(63, 76);
            this.stackBox0.Name = "stackBox0";
            this.stackBox0.ReadOnly = true;
            this.stackBox0.Size = new System.Drawing.Size(100, 23);
            this.stackBox0.TabIndex = 2;
            this.stackBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(63, 106);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(100, 23);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(27, 172);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 30);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "In/Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stack 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stack 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stack 2";
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(63, 172);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(30, 30);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(99, 172);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(30, 30);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(26, 208);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 30);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(63, 208);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 30);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(99, 208);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(30, 30);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(27, 244);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(63, 244);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 30);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(99, 244);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(27, 280);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(66, 30);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(99, 280);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(30, 30);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(99, 136);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(30, 30);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "*";
            this.btnMultiply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(63, 136);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 30);
            this.btnDivide.TabIndex = 20;
            this.btnDivide.Text = "/";
            this.btnDivide.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(27, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CL";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(135, 136);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(135, 172);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 66);
            this.btnPlus.TabIndex = 23;
            this.btnPlus.Text = "+";
            this.btnPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.Location = new System.Drawing.Point(135, 244);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(30, 66);
            this.btnEnter.TabIndex = 24;
            this.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 326);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.stackBox0);
            this.Controls.Add(this.stackBox1);
            this.Controls.Add(this.stackBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "winRPN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stackBox2;
        private System.Windows.Forms.TextBox stackBox1;
        private System.Windows.Forms.TextBox stackBox0;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEnter;
    }
}

