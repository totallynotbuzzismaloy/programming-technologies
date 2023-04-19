namespace tp_8thLab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.printSubMatrix = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixColumnSize = new System.Windows.Forms.NumericUpDown();
            this.matrixRowSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.showDataButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixColumnSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixRowSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 746);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox8);
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.printSubMatrix);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.matrixColumnSize);
            this.tabPage1.Controls.Add(this.matrixRowSize);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.showDataButton);
            this.tabPage1.Controls.Add(this.openFileButton);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Location = new System.Drawing.Point(89, 591);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(158, 24);
            this.checkBox8.TabIndex = 26;
            this.checkBox8.Text = "На другую форму";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(89, 569);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(158, 24);
            this.checkBox7.TabIndex = 25;
            this.checkBox7.Text = "На 2-ю вкладку";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // printSubMatrix
            // 
            this.printSubMatrix.Location = new System.Drawing.Point(68, 621);
            this.printSubMatrix.Name = "printSubMatrix";
            this.printSubMatrix.Size = new System.Drawing.Size(201, 74);
            this.printSubMatrix.TabIndex = 24;
            this.printSubMatrix.Text = "вывести подматрицу";
            this.printSubMatrix.UseVisualStyleBackColor = true;
            this.printSubMatrix.Click += new System.EventHandler(this.printSubMatrix_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(68, 290);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(285, 24);
            this.checkBox6.TabIndex = 23;
            this.checkBox6.Text = "Русские и латинский символы";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(68, 260);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(285, 24);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "Латинские символы";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(68, 230);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(285, 24);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Русские символы";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(68, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 48);
            this.label6.TabIndex = 20;
            this.label6.Text = "Эти настройки применимы для строк, содержащих";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(68, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Настройки преобразования строк";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(68, 152);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(285, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Не преобразовывать";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(68, 122);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(285, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Первый символ всех слов";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(68, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(285, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Верхний/нижний регистр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(522, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "M:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(522, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "N:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(559, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Размерность подматрицы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrixColumnSize
            // 
            this.matrixColumnSize.Location = new System.Drawing.Point(559, 132);
            this.matrixColumnSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.matrixColumnSize.Name = "matrixColumnSize";
            this.matrixColumnSize.Size = new System.Drawing.Size(139, 22);
            this.matrixColumnSize.TabIndex = 12;
            this.matrixColumnSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.matrixColumnSize.ValueChanged += new System.EventHandler(this.matrixColumnSize_ValueChanged);
            // 
            // matrixRowSize
            // 
            this.matrixRowSize.Location = new System.Drawing.Point(559, 104);
            this.matrixRowSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.matrixRowSize.Name = "matrixRowSize";
            this.matrixRowSize.Size = new System.Drawing.Size(138, 22);
            this.matrixRowSize.TabIndex = 11;
            this.matrixRowSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.matrixRowSize.ValueChanged += new System.EventHandler(this.matrixRowSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(511, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Изначальная матрица";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(68, 489);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(201, 74);
            this.showDataButton.TabIndex = 9;
            this.showDataButton.Text = "вывести изначальную матрицу";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(68, 409);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(201, 74);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(511, 528);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 180);
            this.listBox1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(251, 158);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(493, 340);
            this.listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 744);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrixColumnSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixRowSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;

        private System.Windows.Forms.Button printSubMatrix;

        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown matrixRowSize;
        private System.Windows.Forms.NumericUpDown matrixColumnSize;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button openFileButton;

        private System.Windows.Forms.Button showDataButton;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}