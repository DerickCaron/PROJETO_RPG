using System;
using RPG_PROJETO.src.Entity;
namespace RPG_PROJETO
{
    class Program
    {
        static void Main(string[] args)
        {  
          Hero Thor = new Hero("Thor", 23, "Knight");
          Wizard enemy1 = new Wizard("Wizard", 43, "powerful");
          RedKnight enemy2= new RedKnight("RedKnight", 45, "spear");
          Archer enemy3= new Archer("Archer", 32, "arrow");
          Gladiator enemy4= new Gladiator("Gladiator", 28, "blow");
          Ninja enemy5= new Ninja("Ninja", 30, "shuriken");

          Console.WriteLine(Thor.attack());
          Console.WriteLine(enemy1.attack(5));
          Console.WriteLine(enemy2.attack(7));
          Console.WriteLine(enemy3.attack(9));
          Console.WriteLine(enemy4.attack(6));
          Console.WriteLine(enemy5.attack(10));


        }
    }
}
