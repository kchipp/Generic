using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {

            GenericList<string> greeting = new GenericList<string>(new string[] { "hello", "hallo", "bonjour", "hola" });
            GenericList<string> language = new GenericList<string>(new string[] { "english", "dutch", "french", "spanish" });


            Console.WriteLine($"Primary List");
            greeting.Show();



            greeting.Add("kon'nichiwa");
            greeting.Add("ciao");
            language.Add("japanese");
            language.Add("italian");
            Console.WriteLine("\nAdd Items");
            greeting.Show();

            greeting.Remove("hallo");
            greeting.Remove("hola");
            language.Remove("dutch");
            language.Remove("spanish");
            Console.WriteLine("\nRemove items");
            greeting.Show();


            Console.WriteLine("\nTo String");
            Console.WriteLine(greeting.ToString());

            Console.WriteLine($"String count: {greeting.Count}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nOverload of '+' operator w/ Strings");
            GenericList<string> combineStrings = greeting + language;
            Console.WriteLine(combineStrings);

            Console.WriteLine("\nOverload of '-' Operator w/ Ints");
            GenericList<int> myNumbers = new GenericList<int>(new int[] { 2, 16, 19, 52, 87 });
            GenericList<int> favNumbers = new GenericList<int>(new int[] { 2, 16, 52, });
            GenericList<int> remainingNumbers = myNumbers - favNumbers;
            Console.WriteLine(remainingNumbers);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\nIterable Display");
            Iterable sns = new Iterable();
            foreach (var item in sns)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\nZipper function");
            language.Zipper(greeting);
            foreach (var item in language)
            {
                Console.WriteLine(item);
            }
            greeting.Zipper(language);
            foreach (var item in greeting)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();




        }
    }//class
}//namespace