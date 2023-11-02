using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Voiture
    {
        private string numeroDeChassi;
        private string codeDeClé;


        public Voiture(Voiture x)
        {
            this.vitesse = x.vitesse;
            this.NumeroChassi = x.NumeroChassi;
        }

        internal Voiture(string numeroChassi, string codeClé, Object x)
        {
            numeroDeChassi = numeroChassi;
            codeDeClé = codeClé;
        }

        public Voiture(string codeClé)
        {
            codeDeClé = codeClé;
        }

        private Voiture(string numeroChassi, bool checkEngine, bool checkEngine, int vitesse)
        {
            NumeroChassi = numeroChassi;
            CheckEngine = checkEngine;
            CheckEngine = checkEngine;
            this.vitesse = vitesse;
        }

        public string NumeroChassi
        {
            get { return numeroDeChassi; }
            set { numeroDeChassi = value; }
        }

        private bool checkEngine;

        public bool CheckEngine
        {
            get => checkEngine;
            set => checkEngine = value;
        }

        public int vitesse { get; set; }

        public string marque(string marque) => marque;

        public static Voiture operator +(Voiture voiture1, Voiture voiture2)
        {
            voiture1.vitesse += voiture2.vitesse;
            return voiture1;
        }

        public static bool operator == (Voiture voiture1, Voiture voit2)
        {
            return true;
        }
        public static bool operator != (Voiture voiture1, Voiture voit2)
        {
            return false;
        }
    }
}
