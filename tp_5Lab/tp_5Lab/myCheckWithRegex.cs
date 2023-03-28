using System;
using System.Text.RegularExpressions;

namespace tp_5Lab
{
    public class myCheckWithRegex
    {
        private string myPattern = @"^([-]?\d*[.,]?\d+)\ (\d+)\ ([-]?\d*[.,]?\d+)\ (\d+)";
        //private string myPattern = @"^([-]?\d*[.,]?\d+)\ (\d+)\ ([-]?\d*[.,]?\d+)";
        public bool myCheck(string receivedStr)
        {
            string pattern = @"^(([-]?\d*[.,]?\d+)\ (\d+)\ ([-]?\d*[.,]?\d+)\ (\d+))$";
            return Regex.IsMatch(receivedStr, pattern); //@"^([-]?\d*[.,]?\d+)\ (\d+)\ ([-]?\d*[.,]?\d+)\ (\d+)");
        }

        public string getCorrectString(string receivedStr)
        {
            var myMatch = Regex.Match(receivedStr, myPattern).ToString();
            return myMatch;
        }

        public double[] getInputs(string receivedData)
        {
            //var myMatch = Regex.Match(receivedData, @"([-]?\d+)\ (\d+)\ ([-]?\d+)\ (\d+)");
            var myMatch = Regex.Match(receivedData, myPattern); //@"^([-]?\d*[.,]?\d+)\ (\d+)\ ([-]?\d*[.,]?\d+)\ (\d+)");
            var checkStr = myMatch.ToString();
            double[] returnArray = { };
            if (checkStr.Contains("."))
            {
                var tempStr = checkStr.Replace(".", ",");
                myMatch = Regex.Match(tempStr, @"^([-]?\d*[,]?\d+)\ (\d+)\ ([-]?\d*[,]?\d+)\ (\d+)");
                //myMatch = Regex.Match(tempStr, @"^([-]?\d*[,]?\d+)\ (\d+)\ ([-]?\d*[,]?\d+)");
                var groups = myMatch.Groups;
                var firstNumb = Convert.ToDouble(groups[1].ToString());
                var secondNumb = Convert.ToDouble(groups[2].ToString());
                var thirdNumb = Convert.ToDouble(groups[3].ToString());
                var fourthNumb = Convert.ToDouble(groups[4].ToString());
                returnArray = new[] { firstNumb, secondNumb, thirdNumb, fourthNumb};
            }
            else
            {
                var groups = myMatch.Groups;
                //var NumbGroup = Convert.ToDouble(groups[0].ToString());
                var firstNumb = Convert.ToDouble(groups[1].ToString());
                var secondNumb = Convert.ToDouble(groups[2].ToString());
                var thirdNumb = Convert.ToDouble(groups[3].ToString());
                var fourthNumb = Convert.ToDouble(groups[4].ToString());
                returnArray = new[] { firstNumb, secondNumb, thirdNumb, fourthNumb};
            }

            return returnArray;
            
            
        }

        public string getTheNameOfProgram()
        {
            var tempStr = System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName;
            var secondStr = Regex.Match(tempStr, @"[^\\]*$").ToString();
            var returnStr = Regex.Match(secondStr, @"^(\w+)").ToString();
            return returnStr;
        }
    }
}