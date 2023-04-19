using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace tp_8thLab
{
    public class myReadFile
    {
        public string mySelectPath()
        {
            var returnPath = string.Empty;
            using (var myFileDialog = new OpenFileDialog())
            {
                myFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                myFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                myFileDialog.FilterIndex = 1;
                myFileDialog.RestoreDirectory = true;
                if (myFileDialog.ShowDialog() != DialogResult.OK) ;
                //var fs = myFileDialog.OpenFile();
                else
                {
                    returnPath = myFileDialog.FileName;
                    
                }
            }

            return returnPath;
        }
        
        
        public List<string> myGetListOfStrings(string filePath)
        {
            List<string> myRetList = new List<string>();
            using (var sr = new StreamReader(filePath))
            {
                //string line;
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    myRetList.Add(line);
                }
            }

            return myRetList;
        }

        public List<string[]> myConvert(List<string> receivedList)
        {
            var returnList = new List<string[]>();
            foreach(var line in receivedList) returnList.Add(line.Split(' '));
            return returnList;
        }

        public List<string[]> returnListStringArrays(string filePath)
        {
            var res = new List<string[]>();
            var readText = File.ReadAllLines(filePath);
            foreach(var line in readText) res.Add(line.Split(' '));

            return res;
        }
    }
}