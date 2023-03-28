using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_5Lab
{
    public partial class Form1 : Form
    {
        private static string myFunction = "y * 2^(ln(x-1))";
        private static int myVariant = 28;
        //= System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName;
        private int selectedIndex;
        
        private static myReadTheFile _myRead = new myReadTheFile();
        private myFuncCalculate _myFunc = new myFuncCalculate();
        private string selectedInput = string.Empty;
        private myCreateFiles _myCreateFiles = new myCreateFiles(_myRead.getTheNameOfProgram(), myVariant, myFunction);
        private List<string> ListWithNames = new List<string>();

        private string datFileToShow;
        //private myCheckWithRegex _myRegex = new myCheckWithRegex();
        //private bool incorrectInput = false;
        
        public Form1()
        {
            InitializeComponent();
            Text = "calculations, lol";
            //myProgramName = Text;
            _myCreateFiles.myWriteHeader();
        }
        

        /*private void myfillListBox()
        {
            var myReader = new List<string>();
            using (var myFileDialog = new OpenFileDialog())
            {
                myFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                myFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                myFileDialog.FilterIndex = 1;
                myFileDialog.RestoreDirectory = true;
                if (myFileDialog.ShowDialog() != DialogResult.OK) return;
                var fs = myFileDialog.OpenFile();
                using (var sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        myReader.Add(_myRegex.myCheck(line) ? line : _myRegex.getCorrectString(line));
                        incorrectInput = true;
                    }
                }
                listBox1.DataSource = myReader;
                fs.Close();
            }
        }*/


        private void chooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                //myfillListBox();
                //if (incorrectInput)
                listBox1.DataSource = _myRead.myReturnInputData();
                if(_myRead.incorrectInput)
                {
                    var message = "There was/were incorrect args, they have been replaced";
                    var title = "Invalid input";
                    var button = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, button, MessageBoxIcon.Information);
                    _myRead.incorrectInput = false;
                }
            }
            catch (Exception error)
            {
                var title = "Error has been occured";
                var button = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(), title, button, MessageBoxIcon.Warning);
            }
        }

        private void printTheInfo(double?[,] outputArray, double x0, double step)
        {

            for (var i = 0; i < outputArray.GetUpperBound(1) + 1; i++)
            {
                richTextBox1.Text += $"\t{i + 1, 8} ";
            }
            richTextBox1.Text += Environment.NewLine;
            
            for (var i = 0; i < outputArray.GetUpperBound(0) + 1; ++i)
            {
                var myX = x0 + step * i;
                richTextBox1.Text += $" {Math.Round(myX, 3), 8} ";
                for (var j = 0; j < outputArray.GetUpperBound(1) + 1; ++j)
                {
                    if (outputArray[i, j] != null)
                        richTextBox1.Text += $@"{outputArray[i,j], 10} "; //$"G({myX,5};{i + 1,5}): {outputArray[i, j],5}{Environment.NewLine}";

                    else
                        richTextBox1.Text +=
                            $"  {"  Null  ", 10}  "; //$"The func doesnt exist in ({myX,5};{i + 1,5}){Environment.NewLine}";
                }

                richTextBox1.Text += Environment.NewLine;
            }
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!_myRead.myCheck(selectedInput)) return;
                double[] myArray = _myRead.getInputs(selectedInput);
                double?[,] outputArray = _myFunc.calculateMyFunc(myArray[0], (int)myArray[1], myArray[2], (int)myArray[3]);
                richTextBox1.Clear();
                richTextBox1.Text = $"X0:\tAmount X\t step\tAmount Y{Environment.NewLine}";
                richTextBox1.Text += $"{myArray[0]}\t {myArray[1]}\t{myArray[2]}\t{myArray[3]}{Environment.NewLine}";
                printTheInfo(outputArray, myArray[0],myArray[2]);
                var tempFileName = string.Format("G{0:####}.dat", selectedIndex);
                datFileToShow = tempFileName;
                if (ListWithNames.Contains(tempFileName)) return;
                ListWithNames.Add(tempFileName);
                _myCreateFiles.myCheckAndCreateFile(tempFileName);
                for (var i = 0; i < outputArray.GetUpperBound(0) + 1; ++i)
                {
                    var myX = myArray[0] + myArray[2] * i;
                    for (var j = 0; j < outputArray.GetUpperBound(1) + 1; ++i)
                    {
                        if(outputArray[i,j] == null) _myCreateFiles.myCreateErrorFile(tempFileName,myX, j+1, "Arithmetic Exception");
                    }
                }
            }
            catch (Exception error)
            {
                var title = "error";
                _myCreateFiles.myCreateErrorFile(datFileToShow, Double.NaN, null, error.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInput = listBox1.SelectedItem.ToString();
            selectedIndex = listBox1.SelectedIndex;
        }
    }
}