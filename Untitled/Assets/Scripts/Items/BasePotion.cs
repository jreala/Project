using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem
{
    public enum PotionTypes
    {
        HEALTH,
        MANA,
        STAMINA,
        STRENGTH,
        DEXTERITY,
        AGILITY,
        INTELLIGENCE
    }

    private PotionTypes potionType;

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
}
