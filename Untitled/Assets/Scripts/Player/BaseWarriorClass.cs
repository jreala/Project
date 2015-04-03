using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass 
{
    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A brutal hero.";

        Stamina = 100;
        Mana = 0;
        Strength = 10;
        Dexterity = 5;
        Agility = 4;
        Intelligence = 0;
    }
}
