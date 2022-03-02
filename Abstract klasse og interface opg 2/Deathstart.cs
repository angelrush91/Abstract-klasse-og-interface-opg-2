using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_2
{
    internal class Deathstar:Spacestation
    {
        public override void Firelaser()
        {
            Console.WriteLine("death star");
            Console.WriteLine("3... 2... 1... BANG");
            SoundPlayer player = new SoundPlayer(@"C:\Users\mathi\Downloads\STAR-WARS-AT-AT-FIRING-SOUND-EFFECT-2.wav");
            player.Play();
            Console.WriteLine("pew pew pew pew");
        }
    }
}
