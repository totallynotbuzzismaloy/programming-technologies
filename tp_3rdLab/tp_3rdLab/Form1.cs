using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_3rdLab
{
    public partial class Form1 : Form
    {
        private Functions _calc = new Functions();
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StartX.Text = "0";
            EndX.Text = "1000";
            pointNumb.Text = "1000";
        }
        

        private void ClearFunc_Click(object sender, EventArgs e)
        {
            FuncResult.Clear();
        }

        private void CountFunc_Click(object sender, EventArgs e)
        {
            var flag = false;
            try
            {
                if (StartX.Text != null && EndX.Text != null && pointNumb.Text != null)
                {
                    var inputBegin = StartX.Text;
                    var inputEnd = EndX.Text;
                    var inputNumb = pointNumb.Text;
                    var beginX = double.Parse(inputBegin);
                    var endX = double.Parse(inputEnd);
                    var pointsNumb = Math.Abs(int.Parse(inputNumb));
                    if (pointsNumb < 1000) throw new Exception("Количество точек должно быть больше 1000");
                    var result = _calc.calculate_FXi(beginX, endX, pointsNumb);
                    FuncResult.Text = result.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    StartX.Text = "1";
                    EndX.Text = "1001";
                    pointNumb.Text = "1000";
                    var inputBegin = StartX.Text;
                    var inputEnd = EndX.Text;
                    var inputNumb = pointNumb.Text;
                    var beginX = double.Parse(inputBegin);
                    var endX = double.Parse(inputEnd);
                    var pointsNumb = Math.Abs(int.Parse(inputNumb));
                    var result = _calc.calculate_FXi(beginX, endX, pointsNumb);
                    FuncResult.Text = result.ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception error)
            {
                var title = "Error message";
                var button = MessageBoxButtons.OK;
                var result = MessageBox.Show(error.ToString(), title, button);
                if (result == DialogResult.OK) ;

                    flag = true;
            }

            try
            {
                if (!flag) throw new Exception();
            }
            catch
            {
                var title = "Error message";
                var message = "искусственно вызываю ошибку";
                var button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                if (result == DialogResult.OK)
                {
                    ;
                }

                flag = false;
            }
        }
    }
}