using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Bateau
    {
        public Bateau(int vitesse, long longueur)
        {
            this.vitesse = vitesse;
            this.longueur = longueur;
        }

        public Bateau(string nom, int vitesse, long longueur)
        {
            Nom = nom;
            this.vitesse = vitesse;
            this.longueur = longueur;
        }

        public string Nom { get; set; }
        public int vitesse { get; set; }
        public long longueur { get; set; }

    }
}
