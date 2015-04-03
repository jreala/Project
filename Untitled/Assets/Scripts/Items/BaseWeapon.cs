using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem // BaseWeapon <- BaseStatItem <- BaseItem
{
    public enum WeaponTypes
    {
        AXE,
        SWORD,
        DAGGER,
        SHIELD,
        BOW,
        STAFF,
        GREATAXE,
        GREATSWORD
    }

    private WeaponTypes weaponType;
    private int weaponModifierID;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int WeaponModifierID
    {
        get { return weaponModifierID; }
        set { weaponModifierID = value; }
    }
}
