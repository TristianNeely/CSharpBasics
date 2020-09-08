using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Tristian!");
            //MyString();

            //Console.ReadLine();

            //myHoomans();

            //myCharacterClass();

            RunFlowControl();
        }

        static void RunFlowControl()
        {
            FlowControl.FlowControl.FCIfElse();
        }

        static void myCharacterClass()
        {
            CharacterClass oldNinja = new CharacterClass();
            CharacterClass MediumSamurai = new CharacterClass();
            CharacterClass youngNinja = new CharacterClass();

            oldNinja.CharacterName = "Ninjafiveo";
            oldNinja.CharacterLevel = 105;
            oldNinja.CharacterRace = "Human";
            oldNinja.HitPoints = 5000;
            oldNinja.CharClass = "Mage";
            oldNinja.inGuild = true;


            MediumSamurai.CharacterName = "Bob";
            MediumSamurai.CharacterLevel = 55;
            MediumSamurai.CharacterRace = "Orc";
            MediumSamurai.HitPoints = 5000;
            MediumSamurai.CharClass = "Warrior";
            MediumSamurai.inGuild = true;

            youngNinja.CharacterName = "Fred";
            youngNinja.CharacterLevel = 30;
            youngNinja.CharacterRace = "Orc";
            youngNinja.HitPoints = 5000;
            youngNinja.CharClass = "Warrior";
            youngNinja.inGuild = false;
            youngNinja.CharacterSelect();
            Console.WriteLine();



        }


        static void myHoomans()
        {
            HooManClass MrSekol = new HooManClass();
            MrSekol.age = 99;
            MrSekol.dogName = "Mozzy";
            MrSekol.hasDog = true;
            MrSekol.name = "Michael";
            MrSekol.Greeting();

            HooManClass Gaveeen = new HooManClass();
            Gaveeen.age = 23;
            Gaveeen.hasDog = false;
            Gaveeen.name = "NotRudiak";
            Gaveeen.Greeting();
        }

        static void MyString()
        {
            //Console.Write("what year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first String.";
            string theTruth = "The last thing a ninja would do is admit to being a ninja";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
        }
    }
}