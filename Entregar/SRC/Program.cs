using System;
using Entregar.SRC.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight(" Arus ", 12 , " Knight ",749,72);
            Wizard wizard = new Wizard(" Jennica ", 12 , " White Wizzard ",601,482);
            Ninja ninja = new Ninja(" Wedge ",12," Black Wizard ",574,89);
            WizardBlack wizardBlack = new WizardBlack(" Topapa ",12," Black Wizard ",385,611);

            Console.WriteLine(wizard.Perfil());
            Console.WriteLine(hero. Perfil());
            Console.WriteLine(ninja.Perfil());
            Console.WriteLine(wizardBlack.Perfil());
        }
    }
}