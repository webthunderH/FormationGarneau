using System;
using System.Buffers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BONJOUR BONJOUR");
            string nom = Console.ReadLine();
            Console.WriteLine(@$"Comment ca va ? {nom}");
            int x = add(1);
            Console.WriteLine(2);
            Ferrari EduardoCar = new Ferrari(""); 
            Voiture adonisCar = new Voiture("");
            Voiture jeanCar = adonisCar;
            Voiture z = jeanCar + EduardoCar + adonisCar;
            Voiture milaineCar = new Ferrari("");
            Utilitaire.estAccidenté(true);
            List<Voiture> list = new List<Voiture>();
            Object a = new Ferrari("");
            
            list.Add(EduardoCar);
            list.Add(adonisCar);
            list.Add(jeanCar);
            list.Add(milaineCar);
            int w = 1 + 1; 
            for (int i = 0; i < 2; i+=5)
            {
                Console.WriteLine(i);
            }
            foreach (Voiture voiture in list)
            {   
                int O = list.IndexOf(voiture) - 1;
                
                Console.WriteLine(voiture.ToString());
            }
            list.ForEach(x => Console.WriteLine(x));
            Console.Read();
        }
        static int add(int x) {  return x + 1; }
        static void add(int x, int y) {  Console.WriteLine(x); }
    }
}