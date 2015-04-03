using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon newWeapon;

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
        
        // Assign name to weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        // Create weapon description
        newWeapon.ItemDescription = "This is a new weapon.";
        // Weapon ID
        newWeapon.ItemID = Random.Range(1, 101);
        // Stats
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Mana = Random.Range(1, 11);
        newWeapon.Strength = Random.Range(1, 11);
        newWeapon.Dexterity = Random.Range(1, 11);
        newWeapon.Agility = Random.Range(1, 11);
        newWeapon.Intelligence = Random.Range(1, 11);
        // Choose Type of Weapon
        ChooseWeaponType();
        // Weapon Modifier
        newWeapon.WeaponModifierID = Random.Range(1, 10);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 9);
        switch(randomTemp)
        {
            case 1:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
                break;
            case 2:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
                break;
            case 3:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
                break;
            case 4:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
                break;
            case 5:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
                break;
            case 6:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
                break;
            case 7:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.GREATAXE;
                break;
            case 8: 
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.GREATSWORD;
                break;
        }
    }
}
