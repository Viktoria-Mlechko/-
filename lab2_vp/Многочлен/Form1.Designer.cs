namespace Многочлен
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_one = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_two = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cof = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pow = new System.Windows.Forms.TextBox();
            this.radioTwo = new System.Windows.Forms.RadioButton();
            this.radioOne = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.btn_itog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_one
            // 
            this.tb_one.Location = new System.Drawing.Point(16, 54);
            this.tb_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_one.Name = "tb_one";
            this.tb_one.Size = new System.Drawing.Size(517, 22);
            this.tb_one.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первый многочлен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второй многочлен";
            // 
            // tb_two
            // 
            this.tb_two.Location = new System.Drawing.Point(16, 107);
            this.tb_two.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_two.Name = "tb_two";
            this.tb_two.Size = new System.Drawing.Size(517, 22);
            this.tb_two.TabIndex = 2;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(16, 139);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(100, 28);
            this.btn_plus.TabIndex = 4;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(124, 139);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(100, 28);
            this.btn_minus.TabIndex = 5;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multy
            // 
            this.btn_multy.Location = new System.Drawing.Point(232, 139);
            this.btn_multy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_multy.Name = "btn_multy";
            this.btn_multy.Size = new System.Drawing.Size(100, 28);
            this.btn_multy.TabIndex = 6;
            this.btn_multy.Text = "*";
            this.btn_multy.UseVisualStyleBackColor = true;
            this.btn_multy.Click += new System.EventHandler(this.btn_multy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(16, 198);
            this.tb_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(517, 96);
            this.tb_result.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_cof);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_pow);
            this.groupBox1.Controls.Add(this.radioTwo);
            this.groupBox1.Controls.Add(this.radioOne);
            this.groupBox1.Location = new System.Drawing.Point(559, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание многочлена";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 230);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "Задать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Коэфициент";
            // 
            // tb_cof
            // 
            this.tb_cof.Location = new System.Drawing.Point(104, 198);
            this.tb_cof.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cof.Name = "tb_cof";
            this.tb_cof.Size = new System.Drawing.Size(132, 22);
            this.tb_cof.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Степень";
            // 
            // tb_pow
            // 
            this.tb_pow.Location = new System.Drawing.Point(104, 166);
            this.tb_pow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_pow.Name = "tb_pow";
            this.tb_pow.Size = new System.Drawing.Size(132, 22);
            this.tb_pow.TabIndex = 11;
            // 
            // radioTwo
            // 
            this.radioTwo.AutoSize = true;
            this.radioTwo.Location = new System.Drawing.Point(8, 53);
            this.radioTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioTwo.Name = "radioTwo";
            this.radioTwo.Size = new System.Drawing.Size(77, 21);
            this.radioTwo.TabIndex = 1;
            this.radioTwo.TabStop = true;
            this.radioTwo.Text = "Второй";
            this.radioTwo.UseVisualStyleBackColor = true;
            // 
            // radioOne
            // 
            this.radioOne.AutoSize = true;
            this.radioOne.Location = new System.Drawing.Point(8, 28);
            this.radioOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOne.Name = "radioOne";
            this.radioOne.Size = new System.Drawing.Size(80, 21);
            this.radioOne.TabIndex = 0;
            this.radioOne.TabStop = true;
            this.radioOne.Text = "Первый";
            this.radioOne.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio3);
            this.groupBox2.Controls.Add(this.btn_itog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_value);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_x);
            this.groupBox2.Controls.Add(this.radio2);
            this.groupBox2.Controls.Add(this.radio1);
            this.groupBox2.Location = new System.Drawing.Point(827, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(260, 266);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычисление";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(8, 78);
            this.radio3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(97, 21);
            this.radio3.TabIndex = 15;
            this.radio3.TabStop = true;
            this.radio3.Text = "Результат";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // btn_itog
            // 
            this.btn_itog.Location = new System.Drawing.Point(8, 230);
            this.btn_itog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_itog.Name = "btn_itog";
            this.btn_itog.Size = new System.Drawing.Size(229, 28);
            this.btn_itog.TabIndex = 10;
            this.btn_itog.Text = "Вычислить";
            this.btn_itog.UseVisualStyleBackColor = true;
            this.btn_itog.Click += new System.EventHandler(this.btn_itog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Результат";
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(104, 198);
            this.tb_value.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(132, 22);
            this.tb_value.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "x = ";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(104, 166);
            this.tb_x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(132, 22);
            this.tb_x.TabIndex = 11;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(8, 53);
            this.radio2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(77, 21);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "Второй";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(8, 28);
            this.radio1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(80, 21);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Первый";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_multy);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_two);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_one);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Калькулятор многочленов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_two;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cof;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pow;
        private System.Windows.Forms.RadioButton radioTwo;
        private System.Windows.Forms.RadioButton radioOne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Button btn_itog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
    }
}

