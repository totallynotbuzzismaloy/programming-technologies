using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace tp_8thLab
{
    public class makeSubMatrix
    {
        public List<string> availableCases = new List<string>() { "all", "first", "none" };
        public List<string> availableLang = new List<string>() { "rus", "eng" };
        

        public string[][] myMakeSubMatrix(int N, int M, string action, List<string[]> originalList)
        {
            var tempArr = originalList.ToArray();
            var mixedLang = availableLang[0] + availableLang[1];
            string[][] returnArr = new string[N][];
            for (var i = 0; i < N; ++i)
            {
                returnArr[i] = new string[M];
                for (var j = 0; j < M; ++j)
                {
                    returnArr[i][j] = tempArr[i][j];
                }
            }

            
            if (action == availableCases[2]) return returnArr;
            else if (action == availableCases[0] + availableLang[0]) return Func1(returnArr);
            else if (action == availableCases[0] + availableLang[1]) return Func2(returnArr);
            else if (action == availableCases[0] + mixedLang) return Func3(returnArr);
            else if (action == availableCases[1] + availableLang[0]) return Func4(returnArr);
            else if (action == availableCases[1] + availableLang[1]) return Func5(returnArr);
            else  return Func6(returnArr); //(action == availableCases[1] + mixedLang)
    
            /*var myFuncDict = new Dictionary<string, Delegate>()
            {
                [availableCases[0] + availableLang[0]] = new Func<string[][], string[][]>(Func1),
                [availableCases[0] + availableLang[1]] = new Func<string[][], string[][]>(Func2),
                [availableCases[0] + mixedLang] = new Func<string[][], string[][]>(Func3),
                [availableCases[1] + availableLang[0]] = new Func<string[][], string[][]>(Func4),
                [availableCases[1] + availableLang[1]] = new Func<string[][], string[][]>(Func5),
                [availableCases[1] + mixedLang] = new Func<string[][], string[][]>(Func6),
            };*/
            //var finalArr = (string[][])myFuncDict[action].DynamicInvoke(returnArr);
            
        }

        private bool contatinsRusSyms(string str)
        {
            var counter = 0;
            foreach(var ch in str)
            {if ((ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я')) counter++;}

            if (counter > 0) return true;
            else return false;
        }

        private bool containsEngSyms(string str)
        {
            var counter = 0;
            foreach (var ch in str)
            { if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) counter++; }

            if (counter > 0) return true;
            else return false;
        }

        private bool containsEngAndRusSyms(string str)
        {
            var Ru = 0;
            var En = 0;
            foreach (var ch in str)
            {
                if ((ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я')) Ru++;
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) En++;
            }

            if (Ru > 0 && En > 0) return true;
            else return false;
        }
        
        private bool isupper(string str)
        {
            var counter = 0;
            foreach (var ch in str)
            { if (char.IsUpper(ch)) counter++; }

            if (counter == str.Length) return true;
            else return false;
        } 

        private string[][] Func1(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for (var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (contatinsRusSyms(returnArr[i][j]))
                    {
                        if (isupper(returnArr[i][j])) returnArr[i][j] = returnArr[i][j].ToLower();
                        else returnArr[i][j] = returnArr[i][j].ToUpper();
                    }
                }
            }
            
            return returnArr;
        }

        /*private bool rusSym(string str)
        {
            var counter = 0;
            foreach (var ch in str)
            { if ((ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я')) counter++; }

            if (counter == str.Length) return true;
            else return false;
        }*/

        private string[][] Func2(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for (var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (containsEngSyms(returnArr[i][j]))
                    {
                        if (isupper(returnArr[i][j])) returnArr[i][j] = returnArr[i][j].ToLower();
                        else returnArr[i][j] = returnArr[i][j].ToUpper();
                    } 
                }
            }
            
            return returnArr;
        }

        /*private bool engSyms(string str)
        {
            var count = 0;
            foreach (var ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) count++;
            }

            if (count == str.Length) return true;
            else return false;
        }*/

        private string[][] Func3(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for (var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (containsEngAndRusSyms(arr[i][j]))
                    {
                        if (isupper(returnArr[i][j])) returnArr[i][j] = arr[i][j].ToLower();
                        else returnArr[i][j] = arr[i][j].ToUpper();
                    } 
                }
            }
            
            return returnArr;
        }

        /*private bool RusAndEngOnly(string str)
        {
            var count = 0;
            foreach (var ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= 'а' && ch <= 'я') ||
                    (ch >= 'А' && ch <= 'Я'))
                    count++;
            }

            if (count == str.Length) return true;
            else return false;
        }*/
        
        private string[][] Func4(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for(var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (contatinsRusSyms(returnArr[i][j]))
                    {
                        var chArr = returnArr[i][j].ToCharArray();
                        chArr[0] = char.ToUpper(chArr[0]);
                        returnArr[i][j] = new string(chArr);
                    }
                }
            }
            
            return returnArr;
        }
        
        private string[][] Func5(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for (var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (containsEngSyms(returnArr[i][j]))
                    {
                        var chArr = returnArr[i][j].ToCharArray();
                        chArr[0] = char.ToUpper(chArr[0]);
                        returnArr[i][j] = new string(chArr);
                    }
                }
            }
            
            return returnArr;
        }
        
        private string[][] Func6(string[][] arr)
        {
            string[][] returnArr = arr;
            for (var i = 0; i < returnArr.Length; ++i)
            {
                for (var j = 0; j < returnArr[i].Length; ++j)
                {
                    if (containsEngAndRusSyms(returnArr[i][j]))
                    {
                        var chArr = returnArr[i][j].ToCharArray();
                        chArr[0] = char.ToUpper(chArr[0]);
                        returnArr[i][j] = new string(chArr);
                    }
                }
            }

            
            return returnArr;
        }
        
       
    }
}