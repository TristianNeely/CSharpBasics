using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class CharacterClass
    {

        // Atributes
        public string CharacterName; public int CharacterLevel; public string CharacterRace; public double HitPoints; public string CharClass;
        public bool inGuild;

        public void CharacterSelect()
        {
            if (CharacterLevel >= 100)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are mighty {CharClass}, of the {CharacterRace} people. You must be a hard one to defeat with {HitPoints} HitPoints. ");
            }
            else if (CharacterLevel >= 50)
            {
                Console.WriteLine($"Welcome {CharacterName}. You are a growing young {CharClass}. The {CharacterRace} people must be looking forward to your developmet. Some day you'll be a hard one to defeat.");
            }
            else
            {

            }
        }
    }
}
