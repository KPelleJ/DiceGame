using System;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line


            Console.WriteLine("Enter the number of sides on your dice");
            int setDice = Convert.ToInt32(Console.ReadLine());
            DiceCup diceCup1 = new DiceCup(setDice);
            
            Console.WriteLine("Press space to shake the dice");
            Console.ReadKey();

            diceCup1.Shake();
            Console.WriteLine(diceCup1.DiceHas());
            Console.WriteLine(diceCup1);
            Console.WriteLine();

            Console.WriteLine("Press space to shake the dice");
            Console.ReadKey();

            diceCup1.Shake();
            Console.WriteLine(diceCup1.DiceHas());
            Console.WriteLine(diceCup1);
            Console.WriteLine();

            Console.WriteLine("Press space to shake the dice");
            Console.ReadKey();

            diceCup1.Shake();
            Console.WriteLine(diceCup1.DiceHas());
            Console.WriteLine(diceCup1);
            Console.WriteLine();

            Console.WriteLine("Press space to shake the dice");
            Console.ReadKey();

            diceCup1.Shake();
            Console.WriteLine(diceCup1.DiceHas());
            Console.WriteLine(diceCup1);
            Console.WriteLine();

            Console.ReadKey();

            // The LAST line of code should be ABOVE this line
        }
    }
}