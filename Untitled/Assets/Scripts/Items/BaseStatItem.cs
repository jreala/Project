using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem 
{
    private int stamina;
    private int mana;
    private int strength;
    private int dexterity;
    private int agility;
    private int intelligence;

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
