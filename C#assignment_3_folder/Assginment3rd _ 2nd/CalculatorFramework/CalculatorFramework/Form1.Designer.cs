namespace CalculatorFramework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.ndivide = new System.Windows.Forms.Button();
            this.nclearall = new System.Windows.Forms.Button();
            this.nclear = new System.Windows.Forms.Button();
            this.nmultiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.nplus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nminus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.LabelCurrentOperations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(30, 140);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(62, 58);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(116, 140);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(62, 58);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(208, 140);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(62, 58);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_click);
            // 
            // ndivide
            // 
            this.ndivide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndivide.Location = new System.Drawing.Point(301, 140);
            this.ndivide.Name = "ndivide";
            this.ndivide.Size = new System.Drawing.Size(62, 58);
            this.ndivide.TabIndex = 3;
            this.ndivide.Text = "/";
            this.ndivide.UseVisualStyleBackColor = false;
            this.ndivide.Click += new System.EventHandler(this.operator_click);
            // 
            // nclearall
            // 
            this.nclearall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nclearall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nclearall.Location = new System.Drawing.Point(386, 140);
            this.nclearall.Name = "nclearall";
            this.nclearall.Size = new System.Drawing.Size(62, 58);
            this.nclearall.TabIndex = 4;
            this.nclearall.Text = "ce";
            this.nclearall.UseVisualStyleBackColor = false;
            this.nclearall.Click += new System.EventHandler(this.button4_Click);
            // 
            // nclear
            // 
            this.nclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nclear.Location = new System.Drawing.Point(386, 222);
            this.nclear.Name = "nclear";
            this.nclear.Size = new System.Drawing.Size(62, 64);
            this.nclear.TabIndex = 9;
            this.nclear.Text = "C";
            this.nclear.UseVisualStyleBackColor = false;
            this.nclear.Click += new System.EventHandler(this.nclear_Click);
            // 
            // nmultiply
            // 
            this.nmultiply.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmultiply.Location = new System.Drawing.Point(301, 222);
            this.nmultiply.Name = "nmultiply";
            this.nmultiply.Size = new System.Drawing.Size(62, 64);
            this.nmultiply.TabIndex = 8;
            this.nmultiply.Text = "*";
            this.nmultiply.UseVisualStyleBackColor = false;
            this.nmultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(208, 222);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(62, 64);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(116, 222);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(62, 64);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(30, 222);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(62, 64);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_click);
            // 
            // nequal
            // 
            this.nequal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nequal.Location = new System.Drawing.Point(386, 311);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(62, 146);
            this.nequal.TabIndex = 19;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = false;
            this.nequal.Click += new System.EventHandler(this.n_equal);
            // 
            // nplus
            // 
            this.nplus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nplus.Location = new System.Drawing.Point(301, 393);
            this.nplus.Name = "nplus";
            this.nplus.Size = new System.Drawing.Size(62, 64);
            this.nplus.TabIndex = 18;
            this.nplus.Text = "+";
            this.nplus.UseVisualStyleBackColor = false;
            this.nplus.Click += new System.EventHandler(this.operator_click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(208, 393);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(62, 64);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.button_click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(30, 393);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(159, 64);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_click);
            // 
            // nminus
            // 
            this.nminus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nminus.Location = new System.Drawing.Point(301, 311);
            this.nminus.Name = "nminus";
            this.nminus.Size = new System.Drawing.Size(62, 58);
            this.nminus.TabIndex = 13;
            this.nminus.Text = "-";
            this.nminus.UseVisualStyleBackColor = false;
            this.nminus.Click += new System.EventHandler(this.operator_click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(208, 311);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(62, 58);
            this.three.TabIndex = 12;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(116, 311);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(62, 58);
            this.two.TabIndex = 11;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(30, 311);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(62, 58);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(30, 58);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(418, 66);
            this.textBoxResult.TabIndex = 20;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelCurrentOperations
            // 
            this.LabelCurrentOperations.AutoSize = true;
            this.LabelCurrentOperations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelCurrentOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentOperations.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelCurrentOperations.Location = new System.Drawing.Point(25, 26);
            this.LabelCurrentOperations.Name = "LabelCurrentOperations";
            this.LabelCurrentOperations.Size = new System.Drawing.Size(0, 29);
            this.LabelCurrentOperations.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 474);
            this.Controls.Add(this.LabelCurrentOperations);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.nplus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nminus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.nclear);
            this.Controls.Add(this.nmultiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nclearall);
            this.Controls.Add(this.ndivide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button ndivide;
        private System.Windows.Forms.Button nclearall;
        private System.Windows.Forms.Button nclear;
        private System.Windows.Forms.Button nmultiply;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button nplus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nminus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label LabelCurrentOperations;
    }
}

