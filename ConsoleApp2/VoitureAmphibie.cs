using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class VoitureAmphibie : Voiture, IBateau
    {
        public VoitureAmphibie(Voiture x, int vitesseFlotaison) : base(x)
        {

        }

        public bool PeutFlotter()
        {
            throw new NotImplementedException();
        }
    }
}
