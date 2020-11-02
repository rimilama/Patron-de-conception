using System;


namespace Patron_conception_protoype
{
    public class Personne
    {
        public int Age;
        public String Nom;

        public Personne(int age, string nom)
        {
            this.Age = age;
            this.Nom = nom;
        }

        public Personne Copy(int age, string nom)
        {
            Personne clone = (Personne)this.MemberwiseClone();
            clone.Age = age;
            clone.Nom = nom;
            return clone;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Personne Michel = new Personne(25, "Michel");
            Personne Ana = Michel.Copy(22, "Ana");
            Console.WriteLine($"{Michel.Age} {Michel.Nom}");
            Console.WriteLine($"{Ana.Age} {Ana.Nom}");
            Console.Read();
        }
    }
}
