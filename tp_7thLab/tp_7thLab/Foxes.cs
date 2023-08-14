using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

namespace tp_7thLab
{
    public partial class Foxes : Form
    {
        private System.Timers.Timer myTimer = new System.Timers.Timer();
        private System.Timers.Timer myCheckTimer = new System.Timers.Timer();
        
        private static int[,] myFoxArray = new int[5,5];
        private static Button[,] myButtons = new Button[5, 5];
        private const int mySize = 64;
        private static ushort currentPin;
        private static bool isFirstStep;
        private static int foxAmount;
        private static int currNumb;
        private static ushort foxFound;
        private static string currentUserName;
        private static Image foxImage;
        
        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=myBDlab7.mdb;";
        //private string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=myBDlab7.mdb;";
        private OleDbConnection myConnection;

        private delegate void myDelegate();

        //private delegate void myDelegateToCheck(Form f);

        public Foxes()
        {
            InitializeComponent();
        }

        public Foxes(Form f, int foxNumb, string userName)
        {
            InitializeComponent();
            //myFoxArray = GenerateFoxPos(foxNumb);
            foxAmount = foxNumb;
            currentUserName = userName;
            InitArray();
            InitButtons(this);
            foxImage = Image.FromFile(Path.Combine(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "fox.jpg"));
            isFirstStep = true;
            currNumb = 0;
            currentPin = 0;
            foxFound = 0;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            f.Hide();
        }

        private static void InitButtons(Foxes foxes)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    var button = new Button();
                    button.Location = new Point(5 + j * mySize, 50 + i * mySize);
                    button.Size = new Size(mySize, mySize);
                    button.Text = "?";
                    button.MouseDown += OnButtonPressedMouse;
                    foxes.Controls.Add(button);
                    myButtons[i, j] = button;
                }
            }
        }
        
        private static void InitArray()
        {
            for (var i = 0; i < 5; ++i)
            {
                for (var j = 0; j < 5; ++j)
                {
                    myFoxArray[i,j] = 0;
                }
            }
        }
        
        private static void GenerateFoxPos(int x, int y)
        {
            var myRand = new Random();
            for (var i = 0; i < foxAmount;)
            {
                var index = myRand.Next(0, 5);
                var secondIndex = myRand.Next(0, 5);
                /*if (myFoxArray[index,secondIndex] != 0 ) continue;
                if(index == x && secondIndex == y) continue; */
                if (myFoxArray[index, secondIndex] != 0 || (index == x && secondIndex == y)) continue;
                myFoxArray[index,secondIndex] = 1;
                i++;
            }
        }

        private static void OnButtonPressedMouse(object sender, MouseEventArgs e)
        {
            var pressedButton = sender as Button;
            switch (e.Button.ToString())
            {
                case "Right":
                    OnRightMousePressed(pressedButton);
                    break;
                case "Left":
                    OnLeftMousePressed(pressedButton);
                    break;
            }
        }

        private static void OnLeftMousePressed(Button pressedButton)
        {
            var indexes = findIndex(pressedButton);
            var numb = 0;
            pressedButton.Enabled = false;
            if (isFirstStep)
            {
                GenerateFoxPos(indexes[0], indexes[1]);
                numb = countHorizontal(indexes[0]) + countVertical(indexes[1]) + countDiagonals(indexes[0], indexes[1]);
                pressedButton.Text = numb <= foxAmount ? numb.ToString() : foxAmount.ToString();
                currNumb++;
                isFirstStep = false;
            }
            else
            {
                currNumb++;
                if (myFoxArray[indexes[0], indexes[1]] == 1)
                {
                    pressedButton.Image = foxImage;//Image.FromFile("C:\\Rider for cpp and cs\\prjects\\tp_7thLab\\tp_7thLab\\fox.jpg");
                    pressedButton.ImageAlign = ContentAlignment.MiddleCenter;
                    pressedButton.Text = string.Empty;
                    foxFound++;
                }
                else
                {
                    numb = countHorizontal(indexes[0]) + countVertical(indexes[1]) + countDiagonals(indexes[0], indexes[1]);
                    pressedButton.Text = numb <= foxAmount ? numb.ToString() : foxAmount.ToString();
                }
                /*string testStrs = string.Empty;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        testStrs += $"{myFoxArray[i, j]}";
                    }

                    testStrs += $"{Environment.NewLine}";
                }

                MessageBox.Show(testStrs, "try", MessageBoxButtons.OK); */
            }
        }

        private static void OnRightMousePressed(Button pressedButton)
        {
            currentPin++;
            currentPin %= 2;
            switch (currentPin)
            {
                case 0:
                    pressedButton.Text = "?";
                    break;
                case 1:
                    pressedButton.Text = "0_0";
                    break;
            }
        }

        private static int[] findIndex(Button pressedButton)
        {
            var returnIndexes = new int[2];
            for (var i = 0; i < 5; i++)
            {
                var found = false;
                for (var j = 0; j < 5; j++)
                {
                    if (pressedButton == myButtons[i, j])
                    {
                        returnIndexes[0] = i;
                        returnIndexes[1] = j;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
            return returnIndexes;
        }

        private static int countHorizontal(int pos1)
        {
            var horizontalFox = 0;
            for (var i = 0; i < 5; i++)
            {
                if (myFoxArray[pos1, i] == 1) horizontalFox++;
            }

            return horizontalFox;
        }

        private static int countVertical(int pos2)
        {
            var verticalFox = 0;
            for (var i = 0; i < 5; i++)
            {
                if (myFoxArray[i, pos2] == 1) verticalFox++;
            }

            return verticalFox;
        }

        private static int countDiagonals(int pos1, int pos2)
        {
            var diagonalFoxes = 0;
            int istep1 = pos1, jstep1 = pos2;
            do
            {
                if (myFoxArray[istep1, jstep1] == 1) diagonalFoxes++;
                istep1++;
                jstep1++;
            } while (istep1 < 5 && jstep1 < 5);

            istep1 = pos1;
            jstep1 = pos2;
            
            do
            {
                if (myFoxArray[istep1, jstep1] == 1) diagonalFoxes++;
                istep1--;
                jstep1--;
            } while (istep1 >= 0 && jstep1 >= 0);
            
            istep1 = pos1;
            jstep1 = pos2;
            
            do
            {
                if (myFoxArray[istep1, jstep1] == 1) diagonalFoxes++;
                istep1--;
                jstep1++;
            } while (istep1 >= 0 && jstep1 < 5);
            
            istep1 = pos1;
            jstep1 = pos2;
            
            do
            {
                if (myFoxArray[istep1, jstep1] == 1) diagonalFoxes++;
                istep1++;
                jstep1--;
            } while (istep1 < 5 && jstep1 >= 0);
            
            return diagonalFoxes;
        }
        
        private void Foxes_Load(object sender, EventArgs e)
        {
            myTimer.Interval = 500;
            myTimer.Elapsed += (o, args) => label1.BeginInvoke(new myDelegate(ElapsedEvent));
            myTimer.Start();
            myCheckTimer.Interval = 50;
            myTimer.Elapsed += (o, args) => label2.BeginInvoke(new myDelegate(secondElapsedEvent));
            myCheckTimer.Start();
        }

        private void secondElapsedEvent()
        {
            if (foxFound == foxAmount)
            {
                this.Close();
                var message = "Поздравляю, вы нашли всех лис!";
                var title = "Поздравление!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void ElapsedEvent()
        {
            label1.Text = currNumb.ToString();
        }


        private void Foxes_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string query = $"INSERT INTO players (user_name, mouse_clicks, fox_amount) VALUES ('{currentUserName}', '{currNumb}', {foxAmount})";
                var command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                myTimer.Stop();
                myCheckTimer.Stop();
            }
            catch (Exception error)
            {
                var title = "An error has been occured";
                MessageBox.Show(error.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}