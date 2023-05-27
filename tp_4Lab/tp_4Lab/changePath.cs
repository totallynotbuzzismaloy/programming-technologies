using System.Text.RegularExpressions;

namespace tp_4Lab;

public class changePath: LanguageCheck
{
    //private Regex _regex = new (@"[^\\]*$");

    public string GetString(string path)
    {
        var returnString = String.Empty;
        try
        {
            if (path != null)
            {
                //var tempStr = _regex.Match(path).ToString();
                var tempStr = Regex.Match(path, @"[^\\]*$").ToString();
                var tempStrings = tempStr.Split(".");
                if (Check(tempStrings[0]))
                {
                    var lower = tempStrings[0].ToLower();
                    var newPath = Regex.Replace(path, @"[^\\]+$", lower);
                    //Console.WriteLine($"the old path is: {path}");
                    //Console.WriteLine(Environment.NewLine);
                    //Console.WriteLine($"The new path is {GenerateNewPath(newPath.Remove(0,3))}");
                    returnString = GenerateNewPath(newPath.Remove(0, 3));
                }
                else returnString = String.Empty;

            }
            else throw new Exception("path is null, please enter not a null path");
        }
        catch (Exception error)
        {
            Console.WriteLine($"You have new Exception:{Environment.NewLine} {error}");
        }

        return returnString;
    }

    private string GenerateNewPath(string oldPath)
    {
        var pattern = "http://mysite.com/";
        var returnString = pattern + oldPath.Replace("\\", "/");
        return returnString;
    }

    
    
    public override bool Check(string myFileName)
    {
        return Regex.IsMatch(myFileName, @"^[а-я].[^a-z]+", RegexOptions.IgnoreCase);
    }
}