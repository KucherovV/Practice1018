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
            this.button1 = new System.Windows.Forms.Button();
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
            this.write_to_f1 = new System.Windows.Forms.Button();
            this.write_to_f2 = new System.Windows.Forms.Button();
            this.read_F1 = new System.Windows.Forms.Button();
            this.Perform = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность:";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(119, 7);
            this.size.Margin = new System.Windows.Forms.Padding(4);
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
            this.size.ReadOnly = true;
            this.size.Size = new System.Drawing.Size(63, 22);
            this.size.TabIndex = 1;
            this.size.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(229, 7);
            this.left.Margin = new System.Windows.Forms.Padding(4);
            this.left.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.left.Name = "left";
            this.left.ReadOnly = true;
            this.left.Size = new System.Drawing.Size(63, 22);
            this.left.TabIndex = 2;
            this.left.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(333, 7);
            this.right.Margin = new System.Windows.Forms.Padding(4);
            this.right.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.right.Name = "right";
            this.right.ReadOnly = true;
            this.right.Size = new System.Drawing.Size(63, 22);
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
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "А=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "В=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Исходный массив:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(140, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 106);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Операция 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 106);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Операция 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(256, 106);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 21);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Операция 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(372, 106);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(108, 21);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "Операция 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(13, 37);
            this.generate.Margin = new System.Windows.Forms.Padding(4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(487, 44);
            this.generate.TabIndex = 10;
            this.generate.Text = "Генерация";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dvg.Location = new System.Drawing.Point(513, 7);
            this.dvg.Margin = new System.Windows.Forms.Padding(4);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(204, 187);
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
            this.richTextBox1.Location = new System.Drawing.Point(728, 30);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(203, 164);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Результаты обработки:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(513, 214);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(204, 28);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // write_to_f1
            // 
            this.write_to_f1.Location = new System.Drawing.Point(16, 135);
            this.write_to_f1.Margin = new System.Windows.Forms.Padding(4);
            this.write_to_f1.Name = "write_to_f1";
            this.write_to_f1.Size = new System.Drawing.Size(115, 28);
            this.write_to_f1.TabIndex = 11;
            this.write_to_f1.Text = "Запись в F1";
            this.write_to_f1.UseVisualStyleBackColor = true;
            this.write_to_f1.Click += new System.EventHandler(this.write_to_f1_Click);
            // 
            // write_to_f2
            // 
            this.write_to_f2.Location = new System.Drawing.Point(140, 135);
            this.write_to_f2.Margin = new System.Windows.Forms.Padding(4);
            this.write_to_f2.Name = "write_to_f2";
            this.write_to_f2.Size = new System.Drawing.Size(115, 28);
            this.write_to_f2.TabIndex = 12;
            this.write_to_f2.Text = "Запись в F2";
            this.write_to_f2.UseVisualStyleBackColor = true;
            this.write_to_f2.Click += new System.EventHandler(this.write_to_f2_Click);
            // 
            // read_F1
            // 
            this.read_F1.Location = new System.Drawing.Point(263, 135);
            this.read_F1.Margin = new System.Windows.Forms.Padding(4);
            this.read_F1.Name = "read_F1";
            this.read_F1.Size = new System.Drawing.Size(115, 28);
            this.read_F1.TabIndex = 13;
            this.read_F1.Text = "Считать из F1";
            this.read_F1.UseVisualStyleBackColor = true;
            this.read_F1.Click += new System.EventHandler(this.read_F1_Click);
            // 
            // Perform
            // 
            this.Perform.Enabled = false;
            this.Perform.Location = new System.Drawing.Point(16, 171);
            this.Perform.Margin = new System.Windows.Forms.Padding(4);
            this.Perform.Name = "Perform";
            this.Perform.Size = new System.Drawing.Size(213, 71);
            this.Perform.TabIndex = 17;
            this.Perform.Text = "Выполнить";
            this.Perform.UseVisualStyleBackColor = true;
            this.Perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "С=";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(437, 7);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 256);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Perform);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.read_F1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.write_to_f2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.write_to_f1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LB #3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.Button write_to_f1;
        private System.Windows.Forms.Button write_to_f2;
        private System.Windows.Forms.Button read_F1;
        private System.Windows.Forms.Button Perform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

