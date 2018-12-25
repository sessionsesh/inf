namespace inf
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Input = new System.Windows.Forms.Button();
            this.label_End = new System.Windows.Forms.Label();
            this.numericUpDownForN = new System.Windows.Forms.NumericUpDown();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(51, 48);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Преобразование:";
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(12, 74);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(139, 40);
            this.button_Input.TabIndex = 5;
            this.button_Input.Text = "Добавить элемент в массив";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // label_End
            // 
            this.label_End.AutoSize = true;
            this.label_End.Location = new System.Drawing.Point(428, 21);
            this.label_End.Name = "label_End";
            this.label_End.Size = new System.Drawing.Size(156, 13);
            this.label_End.TabIndex = 6;
            this.label_End.Text = "Вывод полученного массива:";
            // 
            // numericUpDownForN
            // 
            this.numericUpDownForN.Location = new System.Drawing.Point(153, 23);
            this.numericUpDownForN.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownForN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForN.Name = "numericUpDownForN";
            this.numericUpDownForN.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownForN.TabIndex = 8;
            this.numericUpDownForN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(170, 74);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(145, 40);
            this.buttonConvert.TabIndex = 9;
            this.buttonConvert.Text = "Произвести преобразование массива";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбор размера массива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ввод";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сброс введенных данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonConvert);
            this.groupBox1.Controls.Add(this.button_Input);
            this.groupBox1.Controls.Add(this.textBox_input);
            this.groupBox1.Controls.Add(this.numericUpDownForN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 130);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользовательский ввод";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Допустимое количество вводимых символов 17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 177);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_End);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4 Сорокин Глеб";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.Label label_End;
        private System.Windows.Forms.NumericUpDown numericUpDownForN;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
