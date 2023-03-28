using System;
using System.Collections.Generic;
using System.IO;

namespace tp_5Lab
{
    public class myCreateFiles
    {
        private string programName;
        private int variant;
        private string myFunction;

        private string mainFileName = "myProgram.log";
        private string ErrorFileName = "myErrors.log";
        
        public myCreateFiles(string currProgramName, int currVar, string currFunction)
        {
            programName = currProgramName;
            variant = currVar;
            myFunction = currFunction;
        }


        public void myWriteHeader()
        {
            var currentPath = Directory.GetCurrentDirectory() + "\\" + mainFileName;
            using (var sw = new StreamWriter(currentPath))
            {
                sw.WriteLineAsync($"Название программы: {programName}, вариант: {variant}");
                sw.WriteLineAsync($"{DateTime.Now}");
                sw.WriteLineAsync($"Рассчитываемая функция: {myFunction}");
                sw.WriteLineAsync("Список файлов с результатами:");
            }
        }
        
        public void myCheckAndCreateFile(string fileName)
        {
            var currentPath = Directory.GetCurrentDirectory() + "\\" + mainFileName;
            using (var sw = new StreamWriter(currentPath, true))
            {
                sw.WriteLineAsync(fileName);
            }
            
        }

        public void myCreateErrorFile(string fileName, double x, int? y, string error)
        {
            var currentPath = Directory.GetCurrentDirectory() + "\\" + ErrorFileName;
            using (var sw = new StreamWriter(currentPath, true))
            {
                sw.WriteLineAsync($"Файл: {fileName}");
                sw.WriteLineAsync($"Рассчитываемая функция: {myFunction}");
                sw.WriteLineAsync($"X: {x}, Y:{y}");
                sw.WriteLineAsync(error);
            }
        }

        public void DatFileToCreate(string fileName)
        {
            
        }
    }
}