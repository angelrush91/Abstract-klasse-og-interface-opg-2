using Abstract_klasse_og_interface_opg_2;
using System;

// See https://aka.ms/new-console-template for more information


Spacestation sk = new Skywalker();
Spacestation d = new Deathstar();
Spacestation dV = new Darthvader();

Spacestation[] s = new Spacestation[3];

s[0] = dV;
s[1] = sk;
s[2] = d;

for (int i = 0; i < s.Length; i++)
{
    s[i].Firelaser();
    Console.ReadKey();
  
}

