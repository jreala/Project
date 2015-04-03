using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour 
{
    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Great", "Epic", "Legendary" };
    private string[] itemDescriptions = new string[2] { "New", "Refurbished" };

    void Start()
    {

    }

    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 4)];
        newEquipment.ItemDescription = itemDescriptions[Random.Range(0, 3)];
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemName();
        newEquipment.Stamina = Random.Range(1, 11);
        newEquipment.Mana = Random.Range(1, 11);
        newEquipment.Strength = Random.Range(1, 11);
        newEquipment.Dexterity = Random.Range(1, 11);
        newEquipment.Agility = Random.Range(1, 11);
        newEquipment.Intelligence = Random.Range(1, 11);
    }

    private void ChooseItemName()
    {
        int randomTemp = Random.Range(1, 9);
        switch(randomTemp)
        {
            case 1:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
                break;
            case 2:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BODY;
                break;
            case 3:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
                break;
            case 4:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.WAIST;
                break;
            case 5:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                break;
            case 6:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
                break;
            case 7:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                break;
            case 8:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EAR;
                break;
            case 9:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.WRIST;
                break;
            case 10:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEFTRING;
                break;
            case 11:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RIGHTRING;
                break;
        }
    }

    void Update()
    {

    }
}
