using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQWhere{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Names in list: ");
            List<string> names = new List<string>(){
                "Ania",
                "Sveta",
                "Masha",
                "Ulia",
                "Katia",
                "Alisa"
            };
            foreach(string name in names){
                Console.WriteLine(name);
            }
            Console.WriteLine("Names in array starts from 'A' letter: ");
            string[] namesStartsWithA = names.Where(p => p.StartsWith("A")).ToArray();
            foreach (string name in namesStartsWithA)
            {
                Console.WriteLine(name);
            }
        }
    }
}