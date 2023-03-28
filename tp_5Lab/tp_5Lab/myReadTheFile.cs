using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace tp_5Lab
{
    public class myReadTheFile : myCheckWithRegex
    {
        public bool incorrectInput;
        
        public List<string> myReturnInputData()
        {
            var myReader = new List<string>();
            using (var myFileDialog = new OpenFileDialog())
            {
                myFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                myFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                myFileDialog.FilterIndex = 1;
                myFileDialog.RestoreDirectory = true;
                if (myFileDialog.ShowDialog() != DialogResult.OK) ;
                var fs = myFileDialog.OpenFile();
                using (var sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //myReader.Add(myCheck(line) ? line : getCorrectString(line));
                        if(myCheck(line)) myReader.Add(line);
                        else
                        {
                            incorrectInput = true;
                            myReader.Add(getCorrectString(line));
                        }
                        
                    }
                }
                //listBox1.DataSource = myReader;
                fs.Close();
                return myReader;
            }
        }
    }
}