using UnityEngine;
using System.Collections;

public class BaseCharacterClass
{
    private string characterClassName;
    private string characterClassDescription;

    //Stats
    private int stamina;
    private int mana;
    private int strength;
    private int dexterity;
    private int agility;
    private int intelligence;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }

    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

}
