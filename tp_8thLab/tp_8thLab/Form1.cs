using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_8thLab
{
    public partial class Form1 : Form
    {
        private myReadFile _myReadFile = new myReadFile();
        private makeSubMatrix _myMake = new makeSubMatrix();
        private List<string> myStringList = new List<string>();
        private List<string[]> myTestList = new List<string[]>();
        //private List<string[]> myList = new List<string[]>();
        
        private string myCase;
        private string myLang;
        private string myAction;
        
        private int N;
        private int M;
        
        public Form1()
        {
            InitializeComponent();
            showDataButton.Enabled = false;
            matrixRowSize.Enabled = false;
            matrixColumnSize.Enabled = false;
            printSubMatrix.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox1.Checked = true;
            checkBox4.Checked = true;
            checkBox7.Checked = true;
            myCase = _myMake.availableCases[0];
            myLang = _myMake.availableLang[0];
            myAction = myCase + myLang;
            N = 1;
            M = 1;
        }


        private void openFileButton_Click(object sender, EventArgs e)
        {
            var tempList = new List<Control> {showDataButton, matrixRowSize, matrixColumnSize, printSubMatrix, checkBox7, checkBox8 };
                var path = _myReadFile.mySelectPath();
                myStringList = _myReadFile.myGetListOfStrings(path);
                myTestList = _myReadFile.myConvert(myStringList);
                matrixRowSize.Maximum = myTestList.Count;
                matrixColumnSize.Maximum = myTestList[0].Length;

                foreach (var i in tempList) i.Enabled = true;
        }

            private void showDataButton_Click(object sender, EventArgs e)
            {
                listBox1.DataSource = myStringList;
                //var temp = myTestList.ToArray();
            }


            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox1.Checked)
                {
                    checkBox2.Checked = false;
                    myCase = _myMake.availableCases[0];
                }
                else myCase = string.Empty;
            }

            private void checkBox2_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox2.Checked)
                {
                    checkBox1.Checked = false;
                    myCase = _myMake.availableCases[1];
                }
                else myCase = string.Empty;
            }

            private void checkBox3_CheckedChanged(object sender, EventArgs e)
            {
                var myControlList = new List<CheckBox> { checkBox1, checkBox2, checkBox4, checkBox5, checkBox6 };
                if (checkBox3.Checked)
                {
                    foreach (var i in myControlList)
                    {
                        i.Checked = false;
                        i.Enabled = false;
                    }
                    myCase = _myMake.availableCases[2];
                }
                else
                {
                    foreach (var i in myControlList) i.Enabled = true;
                    myCase = string.Empty;
                }
                    
                
            }

            private void checkBox4_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox4.Checked)
                {
                    checkBox5.Checked = false;
                    myLang = _myMake.availableLang[0];
                }
                else myLang = string.Empty;
            }

            private void checkBox5_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox5.Checked)
                {
                    checkBox4.Checked = false;
                    myLang = _myMake.availableLang[1];
                }
                else myLang = string.Empty;
            }

            private void checkBox6_CheckedChanged(object sender, EventArgs e)
            {
                var tempList = new List<CheckBox> { checkBox4, checkBox5 };
                if (checkBox6.Checked)
                {
                    foreach (var i in tempList)
                    {
                        i.Checked = false;
                        i.Enabled = false;
                    }

                    myLang = _myMake.availableLang[0] + _myMake.availableLang[1];
                }
                else
                {
                    foreach (var i in tempList) i.Enabled = true;
                    myLang = string.Empty;
                }
            }

            private void checkBox7_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox7.Checked) checkBox8.Checked = false;
                else checkBox8.Checked = true;
            }

            private void checkBox8_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox8.Checked) checkBox7.Checked = false;
                else checkBox7.Checked = true;
            }

            private void printSubMatrix_Click(object sender, EventArgs e)
            {
                if (checkBox3.Checked)
                {
                    myAction = _myMake.availableCases[2];
                    myPrint(myAction);
                }
                else if(!checkBox3.Checked && (string.IsNullOrEmpty(myCase) || string.IsNullOrEmpty(myLang)))
                {
                    var msg = "Ошибка: настройки должны быть выбраны во всех полях";
                    MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(!checkBox3.Checked && !string.IsNullOrEmpty(myCase) && !string.IsNullOrEmpty(myLang))
                {
                    myAction = myCase + myLang;
                    myPrint(myAction);
                }
            }

            private void matrixRowSize_ValueChanged(object sender, EventArgs e)
            {
                N = Convert.ToInt32(matrixRowSize.Value);
            }

            private void matrixColumnSize_ValueChanged(object sender, EventArgs e)
            {
                M = Convert.ToInt32(matrixColumnSize.Value);
            }

            private void myPrint(string action)
            {
                if (checkBox7.Checked)
                {
                    listBox2.Items.Clear();
                    var myArr = _myMake.myMakeSubMatrix(N, M, action, myTestList);

                    foreach (var i in myArr)
                    {
                        var tempStr = string.Empty;
                        foreach (var s in i)
                        { tempStr += $"{s} "; }

                        listBox2.Items.Add(tempStr);
                    }
                }
                else
                {   
                    var myArr = _myMake.myMakeSubMatrix(N, M, action, myTestList);
                    var tempList = new List<string>();
                    foreach (var i in myArr)
                    {
                        var temp = string.Empty;
                        foreach (var s in i)
                            temp += $"{s} ";
                        
                        tempList.Add(temp);
                    }

                    var _second = new secondForm(this, tempList);
                    _second.FormClosed += (object s, FormClosedEventArgs ev) => { Show(); };
                    _second.ShowDialog();
                    _second.Close();
                }
            }
    }
}