using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                //свловарь перевода оценок
                Dictionary<int, string> gradesDict = new Dictionary<int, string>
                {
                    {5, "отлично"},
                    {4, "хорошо"},
                    {3, "удовлетворительно"},
                    {2, "неудовлетворительно"}
                };

                //ввод оценок
                Console.Write("Введите оценки через пробел: ");
                string input = Console.ReadLine();
                string[] gradesInput = input.Split();

                Console.WriteLine("\nРезультаты перевода:");
                List<int> numericGrades = new List<int>();

            foreach (string gradeStr in gradesInput)
            {
                if (int.TryParse(gradeStr, out int grade))
                {
                    if (gradesDict.ContainsKey(grade))
                    {
                        Console.WriteLine($"{grade} -> {gradesDict[grade]}");
                        numericGrades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine($"{grade} -> нет такой оценки");
                    }
                }
                else
                {
                    Console.WriteLine($"{gradeStr} -> некорректный ввод");
                }
            }
        }
    }   
}
