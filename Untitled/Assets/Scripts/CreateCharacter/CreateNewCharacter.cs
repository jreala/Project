using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour 
{
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private bool isAssassinClass;

	// Use this for initialization
	void Start () 
    {
        newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
