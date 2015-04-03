using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem 
{
    public enum EquipmentTypes
    {
        HEAD,
        BODY,
        HANDS,
        WAIST,
        LEGS,
        FEET,
        NECK,
        EAR,
        WRIST,
        LEFTRING,
        RIGHTRING
    }

    private EquipmentTypes equipmentType;
    private int armorModifierID;

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int ArmorModifierID
    {
        get { return ArmorModifierID; }
        set { ArmorModifierID = value; }
    }
}
