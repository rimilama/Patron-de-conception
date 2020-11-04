using System;

namespace Patron_conception_fabrique_v2
{

    public abstract class Fabrique
    {
        public abstract string LaFabrique();

        public abstract Chose CreationChose(string nom);
    }

    public class FabriqueHumain : Fabrique
    {
        public override string LaFabrique()
        {
            return "Je suis la fabrique d'humain";
        }

        public override Chose CreationChose(string nom)
        {
            return new Humain(nom);
        }

    }

    public class FabriqueAnimaux : Fabrique
    {
        public override string LaFabrique()
        {
            return "Je suis la fabrique d'animaux";
        }

        public override Chose CreationChose(string nom)
        {
            return new Animaux(nom);
        }

    }




    public abstract class Chose
    {

        public string nom;
        
        public abstract string LaChose();
   

    }

    public class Humain : Chose
    {
        public Humain(string nom)
        {
            this.nom = nom;
        }

        public override string LaChose()
        {
            return $"Je suis un humain et je m'appele {this.nom}";
        }
    }

    public class Animaux : Chose
    {
        public Animaux(string nom)
        {
            this.nom = nom;
        }

        public override string LaChose()
        {
            return $"Je suis une animal et je m'appele {this.nom}";
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            FabriqueHumain fabriqueHumain = new FabriqueHumain();
            Humain humain1 = (Humain)fabriqueHumain.CreationChose("Michel");
            Console.WriteLine($"{fabriqueHumain.LaFabrique()} et j'ai crée {humain1.nom}");
            Console.WriteLine(humain1.LaChose());

            FabriqueAnimaux fabriqueAnimaux = new FabriqueAnimaux();
            Animaux animaux1 = (Animaux)fabriqueAnimaux.CreationChose("Bucky");
            Console.WriteLine($"{fabriqueAnimaux.LaFabrique()} et j'ai crée {animaux1.nom}");
            Console.WriteLine(animaux1.LaChose());

            Console.Read();
        }
    }
}
