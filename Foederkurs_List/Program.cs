using System;
using System.Collections.Generic;
using System.Collections;
namespace Foederkurs_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Colllections
            ArrayList normaleListe = new ArrayList();
            normaleListe.Add(1);
            normaleListe.Add("Karli");
            normaleListe.Add(true);

            foreach (var item in normaleListe)
            {
                Console.WriteLine(item);
            }

            List<string> listOfStrings = new List<string>();


        }
    }
}
