using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour 
{
    private BasePotion newPotion;

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "Consumable";
        newPotion.ItemID = Random.Range(1, 101);
        ChoosePotionType();
    }

    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 7);
        switch(randomTemp)
        {
            case 0:
                newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
                break;
            case 1:
                newPotion.PotionType = BasePotion.PotionTypes.MANA;
                break;
            case 2:
                newPotion.PotionType = BasePotion.PotionTypes.STAMINA;
                break;
            case 3:
                newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
                break;
            case 4:
                newPotion.PotionType = BasePotion.PotionTypes.DEXTERITY;
                break;
            case 5:
                newPotion.PotionType = BasePotion.PotionTypes.AGILITY;
                break;
            case 6:
                newPotion.PotionType = BasePotion.PotionTypes.INTELLIGENCE;
                break;
        }
    }
	
}
