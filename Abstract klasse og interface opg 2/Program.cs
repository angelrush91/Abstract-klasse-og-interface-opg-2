using Abstract_klasse_og_interface_opg_2;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("HEJ");
Console.WriteLine("Hva sker der aer vi glar?");

Spacestation sk = new Skywalker();
Spacestation d = new Deathstar();

Spacestation[] s = new Spacestation[2];

s[0] = sk;
s[1] = d;

for (int i = 0; i < s.Length; i++)
{
    s[i].Firelaser();
  
}
