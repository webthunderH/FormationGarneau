using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ferrari : Voiture, IBateau
    {

        public Ferrari(string codeClé) : base(codeClé)
        {
           
        }

        public bool PeutFlotter()
        {
            throw new NotImplementedException();
        }
    }
}
