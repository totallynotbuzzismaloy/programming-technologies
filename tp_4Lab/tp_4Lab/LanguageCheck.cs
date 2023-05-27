using System.Text.RegularExpressions;

namespace tp_4Lab;

public class LanguageCheck
{
    public virtual bool Check(string myFileName)
    {
        return Regex.IsMatch(myFileName, @"^([a-z]|[а-я])+", RegexOptions.IgnoreCase);
    }
}