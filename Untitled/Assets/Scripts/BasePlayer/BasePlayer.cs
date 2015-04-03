using UnityEngine;
using System.Collections;

public class BasePlayer
{
    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int stamina;
    private int mana;
    private int strength;
    private int dexterity;
    private int agility;
    private int intelligence;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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
