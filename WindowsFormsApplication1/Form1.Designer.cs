namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.perX = new System.Windows.Forms.Button();
            this.quadX = new System.Windows.Forms.Button();
            this.sqrtX = new System.Windows.Forms.Button();
            this.devX = new System.Windows.Forms.Button();
            this.Dev = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.multiolication = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.beq = new System.Windows.Forms.Button();
            this.bfloat = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.plusOrMinus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // perX
            // 
            this.perX.BackColor = System.Drawing.Color.Silver;
            this.perX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perX.Location = new System.Drawing.Point(12, 97);
            this.perX.Name = "perX";
            this.perX.Size = new System.Drawing.Size(80, 46);
            this.perX.TabIndex = 2;
            this.perX.Text = "%";
            this.perX.UseVisualStyleBackColor = false;
            this.perX.Click += new System.EventHandler(this.perX_Click);
            // 
            // quadX
            // 
            this.quadX.BackColor = System.Drawing.Color.Silver;
            this.quadX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quadX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadX.Location = new System.Drawing.Point(97, 97);
            this.quadX.Name = "quadX";
            this.quadX.Size = new System.Drawing.Size(80, 46);
            this.quadX.TabIndex = 3;
            this.quadX.Text = "√";
            this.quadX.UseVisualStyleBackColor = false;
            this.quadX.Click += new System.EventHandler(this.quadX_Click);
            // 
            // sqrtX
            // 
            this.sqrtX.BackColor = System.Drawing.Color.Silver;
            this.sqrtX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtX.Location = new System.Drawing.Point(181, 97);
            this.sqrtX.Name = "sqrtX";
            this.sqrtX.Size = new System.Drawing.Size(80, 46);
            this.sqrtX.TabIndex = 4;
            this.sqrtX.Text = "x²";
            this.sqrtX.UseVisualStyleBackColor = false;
            this.sqrtX.Click += new System.EventHandler(this.sqrtX_Click);
            // 
            // devX
            // 
            this.devX.BackColor = System.Drawing.Color.Silver;
            this.devX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devX.Location = new System.Drawing.Point(265, 97);
            this.devX.Name = "devX";
            this.devX.Size = new System.Drawing.Size(80, 46);
            this.devX.TabIndex = 5;
            this.devX.Text = "1/x";
            this.devX.UseVisualStyleBackColor = false;
            this.devX.Click += new System.EventHandler(this.devX_Click);
            // 
            // Dev
            // 
            this.Dev.BackColor = System.Drawing.Color.Silver;
            this.Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dev.Location = new System.Drawing.Point(265, 148);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(80, 46);
            this.Dev.TabIndex = 9;
            this.Dev.Text = "÷";
            this.Dev.UseVisualStyleBackColor = false;
            this.Dev.Click += new System.EventHandler(this.sum_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.BackColor = System.Drawing.Color.Silver;
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpace.Location = new System.Drawing.Point(181, 148);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(80, 46);
            this.BackSpace.TabIndex = 8;
            this.BackSpace.Text = "←";
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Silver;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(97, 148);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(80, 46);
            this.C.TabIndex = 7;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.Silver;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(12, 148);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(80, 46);
            this.CE.TabIndex = 6;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // multiolication
            // 
            this.multiolication.BackColor = System.Drawing.Color.Silver;
            this.multiolication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiolication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiolication.Location = new System.Drawing.Point(265, 200);
            this.multiolication.Name = "multiolication";
            this.multiolication.Size = new System.Drawing.Size(80, 46);
            this.multiolication.TabIndex = 13;
            this.multiolication.Text = "X";
            this.multiolication.UseVisualStyleBackColor = false;
            this.multiolication.Click += new System.EventHandler(this.sum_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(181, 200);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 46);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.zero_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(97, 200);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 46);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.zero_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 200);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 46);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.zero_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Silver;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(265, 251);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(80, 46);
            this.min.TabIndex = 17;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.sum_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlLight;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(181, 251);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 46);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.zero_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLight;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.ControlText;
            this.five.Location = new System.Drawing.Point(97, 251);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 46);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.zero_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLight;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 251);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 46);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.zero_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.Silver;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(265, 302);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(80, 46);
            this.sum.TabIndex = 21;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLight;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(181, 302);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 46);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.zero_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLight;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(97, 302);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 46);
            this.two.TabIndex = 19;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLight;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 302);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 46);
            this.one.TabIndex = 18;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.zero_Click);
            // 
            // beq
            // 
            this.beq.BackColor = System.Drawing.Color.Silver;
            this.beq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beq.Location = new System.Drawing.Point(265, 354);
            this.beq.Name = "beq";
            this.beq.Size = new System.Drawing.Size(80, 46);
            this.beq.TabIndex = 25;
            this.beq.Text = "=";
            this.beq.UseVisualStyleBackColor = false;
            this.beq.Click += new System.EventHandler(this.beq_Click);
            // 
            // bfloat
            // 
            this.bfloat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bfloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfloat.Location = new System.Drawing.Point(181, 354);
            this.bfloat.Name = "bfloat";
            this.bfloat.Size = new System.Drawing.Size(80, 46);
            this.bfloat.TabIndex = 24;
            this.bfloat.Text = ",";
            this.bfloat.UseVisualStyleBackColor = false;
            this.bfloat.Click += new System.EventHandler(this.zero_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(97, 354);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 46);
            this.zero.TabIndex = 23;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // plusOrMinus
            // 
            this.plusOrMinus.BackColor = System.Drawing.Color.Silver;
            this.plusOrMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOrMinus.Location = new System.Drawing.Point(12, 354);
            this.plusOrMinus.Name = "plusOrMinus";
            this.plusOrMinus.Size = new System.Drawing.Size(80, 46);
            this.plusOrMinus.TabIndex = 22;
            this.plusOrMinus.Text = "±";
            this.plusOrMinus.UseVisualStyleBackColor = false;
            this.plusOrMinus.Click += new System.EventHandler(this.plusOrMinus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(333, 57);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Пред.число:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Тек.знак:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(354, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.beq);
            this.Controls.Add(this.bfloat);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plusOrMinus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.min);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiolication);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.Dev);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.devX);
            this.Controls.Add(this.sqrtX);
            this.Controls.Add(this.quadX);
            this.Controls.Add(this.perX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button perX;
        private System.Windows.Forms.Button quadX;
        private System.Windows.Forms.Button sqrtX;
        private System.Windows.Forms.Button devX;
        private System.Windows.Forms.Button Dev;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button multiolication;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button beq;
        private System.Windows.Forms.Button bfloat;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button plusOrMinus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

