using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_2
{
    internal class Deathstar:Spacestation
    {
        public override void Firelaser()
        {
            Console.WriteLine("3... 2... 1... BANG");
            Console.WriteLine("pew pew pew pew");
        }
    }
}
