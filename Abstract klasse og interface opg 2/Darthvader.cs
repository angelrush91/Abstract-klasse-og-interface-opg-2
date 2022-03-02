using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_2
{
    internal class Darthvader:Spacestation
    {
        public override void Firelaser()
        {
            Console.WriteLine("darth vader");
            SoundPlayer player = new SoundPlayer(@"C:\Users\mathi\Downloads\I-Am-Your-Father_-_Audio_.wav");
            player.Play();
            
        }
    }
}
