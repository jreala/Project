using UnityEngine;
using System.Collections;

public class BaseCasterClass : BaseCharacterClass
{
    public BaseCasterClass()
    {
        CharacterClassName = "Caster";
        CharacterClassDescription = "A versitile mage, master of the dark arts.";

        Stamina = 0;
        Mana = 100;
        Strength = 0;
        Dexterity = 5;
        Agility = 4;
        Intelligence = 10;
    }
}
