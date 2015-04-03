using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour 
{

    private BaseScroll newScroll;

	void Start () {
	
	}
	
    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Scroll";
        newScroll.ItemDescription = "Enchantment";
        newScroll.ItemID = Random.Range(1, 101);
        newScroll.SpellEffectID = Random.Range(1, 11);
    }
}
