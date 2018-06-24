namespace Laba3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.left = new System.Windows.Forms.NumericUpDown();
            this.right = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.generate = new System.Windows.Forms.Button();
            this.write_to_f1 = new System.Windows.Forms.Button();
            this.write_to_f2 = new System.Windows.Forms.Button();
            this.read_F1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Perform = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность:";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(96, 19);
            this.size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(47, 20);
            this.size.TabIndex = 1;
            this.size.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(190, 19);
            this.left.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(47, 20);
            this.left.TabIndex = 2;
            this.left.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(282, 19);
            this.right.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(47, 20);
            this.right.TabIndex = 3;
            this.right.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "А=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "В=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Исходный массив:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(120, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 96);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Операция 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Операция 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Операция 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 165);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "Операция 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(348, 16);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(87, 23);
            this.generate.TabIndex = 10;
            this.generate.Text = "Генерация";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // write_to_f1
            // 
            this.write_to_f1.Location = new System.Drawing.Point(116, 90);
            this.write_to_f1.Name = "write_to_f1";
            this.write_to_f1.Size = new System.Drawing.Size(86, 23);
            this.write_to_f1.TabIndex = 11;
            this.write_to_f1.Text = "Запись в F1";
            this.write_to_f1.UseVisualStyleBackColor = true;
            this.write_to_f1.Click += new System.EventHandler(this.write_to_f1_Click);
            // 
            // write_to_f2
            // 
            this.write_to_f2.Location = new System.Drawing.Point(104, 55);
            this.write_to_f2.Name = "write_to_f2";
            this.write_to_f2.Size = new System.Drawing.Size(86, 23);
            this.write_to_f2.TabIndex = 12;
            this.write_to_f2.Text = "Запись в F2";
            this.write_to_f2.UseVisualStyleBackColor = true;
            this.write_to_f2.Click += new System.EventHandler(this.write_to_f2_Click);
            // 
            // read_F1
            // 
            this.read_F1.Location = new System.Drawing.Point(104, 92);
            this.read_F1.Name = "read_F1";
            this.read_F1.Size = new System.Drawing.Size(86, 23);
            this.read_F1.TabIndex = 13;
            this.read_F1.Text = "Считать из F1";
            this.read_F1.UseVisualStyleBackColor = true;
            this.read_F1.Click += new System.EventHandler(this.read_F1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Perform);
            this.groupBox1.Controls.Add(this.read_F1);
            this.groupBox1.Controls.Add(this.write_to_f2);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // Perform
            // 
            this.Perform.Enabled = false;
            this.Perform.Location = new System.Drawing.Point(3, 119);
            this.Perform.Name = "Perform";
            this.Perform.Size = new System.Drawing.Size(84, 23);
            this.Perform.TabIndex = 17;
            this.Perform.Text = "Выполнить";
            this.Perform.UseVisualStyleBackColor = true;
            this.Perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.Width = 35;
            // 
            // dvg
            // 
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.AllowUserToOrderColumns = true;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvg.Location = new System.Drawing.Point(232, 77);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(134, 173);
            this.dvg.TabIndex = 17;
            this.dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "arr [i]";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(399, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(153, 154);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Результаты обработки:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(399, 233);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(153, 23);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.write_to_f1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 300);
            this.MinimumSize = new System.Drawing.Size(580, 300);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.NumericUpDown left;
        private System.Windows.Forms.NumericUpDown right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arr;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button write_to_f1;
        private System.Windows.Forms.Button write_to_f2;
        private System.Windows.Forms.Button read_F1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.Button Perform;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

