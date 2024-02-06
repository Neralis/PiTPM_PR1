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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonDis = new Button();
            label10 = new Label();
            label11 = new Label();
            buttonClear = new Button();
            buttonFAQ = new Button();
            buttonKor = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 24);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите длины сторон треугольника";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 106);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 2;
            label2.Text = "Тип треугольника по сторонам:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 136);
            label3.Name = "label3";
            label3.Size = new Size(155, 15);
            label3.TabIndex = 2;
            label3.Text = "Тип треуголника по углам:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 166);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 2;
            label4.Text = "Периметр:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 196);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 2;
            label5.Text = "Площадь:";
            // 
            // button1
            // 
            button1.Location = new Point(122, 352);
            button1.Name = "button1";
            button1.Size = new Size(100, 43);
            button1.TabIndex = 3;
            button1.Text = "Определить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 24);
            label6.Name = "label6";
            label6.Size = new Size(256, 15);
            label6.TabIndex = 4;
            label6.Text = "Введите коэффиценты уравнения ax+b^2x+c";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(505, 54);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(611, 54);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(717, 54);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 90);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 8;
            label7.Text = "A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(649, 90);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 9;
            label8.Text = "B";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(756, 90);
            label9.Name = "label9";
            label9.Size = new Size(15, 15);
            label9.TabIndex = 10;
            label9.Text = "C";
            // 
            // buttonDis
            // 
            buttonDis.Location = new Point(578, 128);
            buttonDis.Name = "buttonDis";
            buttonDis.Size = new Size(133, 34);
            buttonDis.TabIndex = 11;
            buttonDis.Text = "Дискриминант";
            buttonDis.UseVisualStyleBackColor = true;
            buttonDis.Click += buttonDis_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(574, 177);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 12;
            label10.Text = "Кол-во корней: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(578, 262);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 13;
            label11.Text = "Результат: ";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(505, 372);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonFAQ
            // 
            buttonFAQ.Location = new Point(742, 372);
            buttonFAQ.Name = "buttonFAQ";
            buttonFAQ.Size = new Size(75, 23);
            buttonFAQ.TabIndex = 15;
            buttonFAQ.Text = "FAQ";
            buttonFAQ.UseVisualStyleBackColor = true;
            buttonFAQ.Click += buttonFAQ_Click;
            // 
            // buttonKor
            // 
            buttonKor.Location = new Point(574, 216);
            buttonKor.Name = "buttonKor";
            buttonKor.Size = new Size(137, 33);
            buttonKor.TabIndex = 16;
            buttonKor.Text = "Корни";
            buttonKor.UseVisualStyleBackColor = true;
            buttonKor.Click += buttonKor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(buttonKor);
            Controls.Add(buttonFAQ);
            Controls.Add(buttonClear);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(buttonDis);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buttonDis;
        private Label label10;
        private Label label11;
        private Button buttonClear;
        private Button buttonFAQ;
        private Button buttonKor;
    }
}
