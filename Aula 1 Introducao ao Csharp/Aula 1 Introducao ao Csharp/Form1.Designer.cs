﻿namespace Aula_1_Introducao_ao_Csharp
{
    partial class Form_Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calculadora));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button18 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button19 = new Button();
            button23 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 121);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1:";
            // 
            // button1
            // 
            button1.Location = new Point(209, 537);
            button1.Name = "button1";
            button1.Size = new Size(33, 39);
            button1.TabIndex = 9;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 162);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Número 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(267, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(195, 242);
            button2.Name = "button2";
            button2.Size = new Size(60, 48);
            button2.TabIndex = 5;
            button2.Text = "7";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(334, 246);
            button3.Name = "button3";
            button3.Size = new Size(60, 44);
            button3.TabIndex = 6;
            button3.Text = "8";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(476, 250);
            button4.Name = "button4";
            button4.Size = new Size(60, 40);
            button4.TabIndex = 7;
            button4.Text = "9";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(195, 342);
            button5.Name = "button5";
            button5.Size = new Size(60, 39);
            button5.TabIndex = 8;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(334, 342);
            button6.Name = "button6";
            button6.Size = new Size(60, 40);
            button6.TabIndex = 9;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(476, 342);
            button7.Name = "button7";
            button7.Size = new Size(60, 40);
            button7.TabIndex = 10;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(195, 443);
            button8.Name = "button8";
            button8.Size = new Size(60, 40);
            button8.TabIndex = 11;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(334, 443);
            button9.Name = "button9";
            button9.Size = new Size(60, 40);
            button9.TabIndex = 12;
            button9.Text = "2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(476, 443);
            button10.Name = "button10";
            button10.Size = new Size(60, 40);
            button10.TabIndex = 13;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(334, 537);
            button11.Name = "button11";
            button11.Size = new Size(60, 40);
            button11.TabIndex = 14;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(476, 537);
            button12.Name = "button12";
            button12.Size = new Size(60, 40);
            button12.TabIndex = 15;
            button12.Text = "Delete";
            button12.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(617, 275);
            button18.Name = "button18";
            button18.Size = new Size(55, 23);
            button18.TabIndex = 3;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button20
            // 
            button20.Location = new Point(617, 242);
            button20.Name = "button20";
            button20.Size = new Size(55, 23);
            button20.TabIndex = 5;
            button20.Text = "-";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Location = new Point(617, 259);
            button21.Name = "button21";
            button21.Size = new Size(55, 23);
            button21.TabIndex = 4;
            button21.Text = "*";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.Location = new Point(617, 351);
            button22.Name = "button22";
            button22.Size = new Size(55, 23);
            button22.TabIndex = 6;
            button22.Text = "÷";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 97);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 96);
            textBox3.TabIndex = 26;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 79);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 27;
            label3.Text = "Resultado:";
            // 
            // button19
            // 
            button19.Location = new Point(617, 443);
            button19.Name = "button19";
            button19.Size = new Size(59, 23);
            button19.TabIndex = 7;
            button19.Text = "√";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button23
            // 
            button23.Location = new Point(617, 546);
            button23.Name = "button23";
            button23.Size = new Size(59, 23);
            button23.TabIndex = 8;
            button23.Text = "^";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // Form_Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(758, 621);
            Controls.Add(button23);
            Controls.Add(button19);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button18);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form_Calculadora";
            Text = "Form_Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button18;
        private Button button20;
        private Button button21;
        private Button button22;
        private TextBox textBox3;
        private Label label3;
        private Button button19;
        private Button button23;
    }
}
