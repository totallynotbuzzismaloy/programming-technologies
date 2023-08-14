namespace tp_7thLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myWarningMessage = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.usersTable = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.deleteSelectedData = new System.Windows.Forms.Button();
            this.moveBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Введите количество лис";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(241, 129);
            this.numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 22);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(241, 264);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 27);
            this.buttonStart.TabIndex = 28;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 37);
            this.textBox1.TabIndex = 29;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(192, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Введите имя пользователя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myWarningMessage
            // 
            this.myWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myWarningMessage.Location = new System.Drawing.Point(58, 214);
            this.myWarningMessage.Name = "myWarningMessage";
            this.myWarningMessage.Size = new System.Drawing.Size(525, 47);
            this.myWarningMessage.TabIndex = 31;
            this.myWarningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(470, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 164);
            this.listBox1.TabIndex = 32;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // usersTable
            // 
            this.usersTable.Location = new System.Drawing.Point(241, 297);
            this.usersTable.Name = "usersTable";
            this.usersTable.Size = new System.Drawing.Size(131, 55);
            this.usersTable.TabIndex = 33;
            this.usersTable.Text = "таблица пользователей";
            this.usersTable.UseVisualStyleBackColor = true;
            this.usersTable.Click += new System.EventHandler(this.usersTable_Click);
            // 
            // showData
            // 
            this.showData.Enabled = false;
            this.showData.Location = new System.Drawing.Point(470, 213);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(150, 50);
            this.showData.TabIndex = 34;
            this.showData.Text = "show";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Visible = false;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // deleteSelectedData
            // 
            this.deleteSelectedData.Enabled = false;
            this.deleteSelectedData.Location = new System.Drawing.Point(630, 214);
            this.deleteSelectedData.Name = "deleteSelectedData";
            this.deleteSelectedData.Size = new System.Drawing.Size(150, 50);
            this.deleteSelectedData.TabIndex = 35;
            this.deleteSelectedData.Text = "delete";
            this.deleteSelectedData.UseVisualStyleBackColor = true;
            this.deleteSelectedData.Visible = false;
            this.deleteSelectedData.Click += new System.EventHandler(this.deleteSelectedData_Click);
            // 
            // moveBack
            // 
            this.moveBack.Enabled = false;
            this.moveBack.Location = new System.Drawing.Point(470, 286);
            this.moveBack.Name = "moveBack";
            this.moveBack.Size = new System.Drawing.Size(309, 51);
            this.moveBack.TabIndex = 36;
            this.moveBack.Text = "back";
            this.moveBack.UseVisualStyleBackColor = true;
            this.moveBack.Visible = false;
            this.moveBack.Click += new System.EventHandler(this.moveBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 364);
            this.Controls.Add(this.moveBack);
            this.Controls.Add(this.deleteSelectedData);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.myWarningMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button moveBack;

        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button usersTable;

        private System.Windows.Forms.Button deleteSelectedData;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myWarningMessage;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}