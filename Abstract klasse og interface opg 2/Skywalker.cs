﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_2
{
     internal class Skywalker:Spacestation
    {
        public override void Firelaser()
        {
            Console.WriteLine("Luke Skywalker");

            SoundPlayer player = new SoundPlayer(@"C:\Users\mathi\Downloads\Luke-says-No.wav");
            player.Play();

        }
    }
}
