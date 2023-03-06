namespace tp_3rdLab
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
            this.FuncResult = new System.Windows.Forms.TextBox();
            this.StartX = new System.Windows.Forms.TextBox();
            this.EndX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointNumb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountFunc = new System.Windows.Forms.Button();
            this.ClearFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FuncResult
            // 
            this.FuncResult.Location = new System.Drawing.Point(243, 106);
            this.FuncResult.Name = "FuncResult";
            this.FuncResult.Size = new System.Drawing.Size(387, 22);
            this.FuncResult.TabIndex = 0;
            // 
            // StartX
            // 
            this.StartX.Location = new System.Drawing.Point(187, 172);
            this.StartX.Name = "StartX";
            this.StartX.Size = new System.Drawing.Size(128, 22);
            this.StartX.TabIndex = 1;
            // 
            // EndX
            // 
            this.EndX.Location = new System.Drawing.Point(321, 172);
            this.EndX.Name = "EndX";
            this.EndX.Size = new System.Drawing.Size(128, 22);
            this.EndX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(187, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "F(Xi) = ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(187, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Задайте диапазон переменных Х";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(187, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "От:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(321, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "До:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointNumb
            // 
            this.pointNumb.Location = new System.Drawing.Point(455, 172);
            this.pointNumb.Name = "pointNumb";
            this.pointNumb.Size = new System.Drawing.Size(175, 22);
            this.pointNumb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(455, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество точек";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountFunc
            // 
            this.CountFunc.Location = new System.Drawing.Point(187, 251);
            this.CountFunc.Name = "CountFunc";
            this.CountFunc.Size = new System.Drawing.Size(443, 45);
            this.CountFunc.TabIndex = 10;
            this.CountFunc.Text = "Рассчитать F(Xi)";
            this.CountFunc.UseVisualStyleBackColor = true;
            this.CountFunc.Click += new System.EventHandler(this.CountFunc_Click);
            // 
            // ClearFunc
            // 
            this.ClearFunc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearFunc.Location = new System.Drawing.Point(455, 197);
            this.ClearFunc.Name = "ClearFunc";
            this.ClearFunc.Size = new System.Drawing.Size(175, 48);
            this.ClearFunc.TabIndex = 9;
            this.ClearFunc.Text = "Clear F(Xi)";
            this.ClearFunc.UseVisualStyleBackColor = false;
            this.ClearFunc.Click += new System.EventHandler(this.ClearFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.CountFunc);
            this.Controls.Add(this.ClearFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointNumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndX);
            this.Controls.Add(this.StartX);
            this.Controls.Add(this.FuncResult);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ClearFunc;

        private System.Windows.Forms.Button CountFunc;

        private System.Windows.Forms.TextBox pointNumb;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox StartX;
        private System.Windows.Forms.TextBox EndX;

        private System.Windows.Forms.TextBox FuncResult;

        #endregion
    }
}