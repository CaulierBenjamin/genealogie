using System;
using System.Collections.Generic;

namespace genealogie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Humain n1 = new Humain("Dantemp","Ludovic","H",new DateTime(1977,05,02));
            Humain n2 = new Humain("Dantemp","Philippe","H",new DateTime(1950,12,24));
            Humain n3 = new Humain("Jorant","Christine","F",new DateTime(1951,05,04));
            Humain n4 = new Humain("Dantemp", "Roland", "H");
            Humain n5 = new Humain("Prince", "Liliane", "F");
            Humain n6 = new Humain("Jorant", "Marceau", "H");
            Humain n7 = new Humain("Couvers", "Rennée", "F");
            
            n1.DefinirMere(n3);
            n1.DefinirPere(n2);
            
            n2.DefinirMere(n5);
            n2.DefinirPere(n4);
            
            n3.DefinirMere(n7);
            n3.DefinirPere(n6);
            //Console.WriteLine(n1.AfficherParents());
            //Console.WriteLine(n2.AfficherParents());
            //Console.WriteLine(n1.Genealogie());
            //enfants
            /*
            n3.DefinirEnfants(n1);
            n2.DefinirEnfants(n1);
            
            Console.WriteLine(n2.AfficherEnfants());
          
            Console.WriteLine(n4.AfficherEnfants());
            Console.WriteLine(n1.AfficherAncetre());
            */
            //Union
            Union u1 = new Union(n3,n2,new DateTime(1950));
            u1.UnionEnfants(n1);
            Console.WriteLine(n2.AfficherEnfants());
            
            Console.ReadKey();
        }
    }
}