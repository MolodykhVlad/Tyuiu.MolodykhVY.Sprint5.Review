using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MolodykhVY.Sprint5.TaskReview.V5.Lib;

namespace Tyuiu.MolodykhVY.Sprint5.TaskReview.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V5.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
