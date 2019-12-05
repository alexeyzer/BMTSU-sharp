namespace laboratornya_rabota5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Отчет = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чтение из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_File);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время чтения из файла";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(275, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "слово для поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время поиска";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(13, 111);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 7;
            this.button_find.Text = "Поиск";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.Button_find_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(423, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 108);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Паралельный нечеткий поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Максимальное растрояние для нечеткого поиска";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(423, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество потоков";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(423, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вычисленное количество потоков";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(423, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Время нечеткого поиска";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(422, 241);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Отчет
            // 
            this.Отчет.Location = new System.Drawing.Point(8, 385);
            this.Отчет.Name = "Отчет";
            this.Отчет.Size = new System.Drawing.Size(100, 23);
            this.Отчет.TabIndex = 21;
            this.Отчет.Text = "Отчет";
            this.Отчет.UseVisualStyleBackColor = true;
            this.Отчет.Click += new System.EventHandler(this.Отчет_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Количество слов";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(275, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 23;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 418);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Отчет);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Поиск в файле";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Отчет;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
    }
}

