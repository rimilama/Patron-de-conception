using System;

namespace Patron_conception
{
    public abstract class Fabrique
    {
        public abstract void LaFabrique();

        public abstract Chose CreationChose();

        public void Result()
        {
            var chose = CreationChose();
            chose.LaChose();
        }
    }

    public class FabriqueHumain : Fabrique
    {
        public override void LaFabrique()
        {
            Console.WriteLine("Je suis la fabrique d'humain");
        }

        public override Chose CreationChose()
        {
            return new Humain();
        } 

    }

    public class FabriqueAnimaux : Fabrique
    {
        public override void LaFabrique()
        {
            Console.WriteLine("Je suis la fabrique d'animaux");
        }

        public override Chose CreationChose()
        {
            return new Animaux();
        }

    }


    public interface Chose
    {
        void LaChose();
    }

    class Humain : Chose
    {
        public void LaChose()
        {
            Console.WriteLine("Je suis un humain");
        }
    }

    class Animaux : Chose
    {
        public void LaChose()
        {
            Console.WriteLine("Je suis un animal");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FabriqueHumain fabriqueHumain = new FabriqueHumain();
            fabriqueHumain.Result();
            fabriqueHumain.LaFabrique();

            FabriqueAnimaux fabriqueAnimaux = new FabriqueAnimaux();
            fabriqueAnimaux.Result();
            fabriqueAnimaux.LaFabrique();
            Console.Read();
        }
    }
}
