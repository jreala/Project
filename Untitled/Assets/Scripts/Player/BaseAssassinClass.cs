using UnityEngine;
using System.Collections;

public class BaseAssassinClass : BaseCharacterClass 
{
    public BaseAssassinClass()
    {
        CharacterClassName = "";
        CharacterClassDescription = "";

        Stamina = 100;
        Mana = 0;
        Strength = 4;
        Dexterity = 10;
        Agility = 5;
        Intelligence = 0;
    }
}
