using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour 
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	void Start () 
    {
        currentState = BattleStates.START;
	}
	
	void Update () 
    {
	    switch(currentState)
        {
            case BattleStates.START :
                // Setup Battle
                // Determine who starts first. Highest Agility makes first move.
                break;
            case BattleStates.PLAYERCHOICE :
                // Pick move. Go to enemy choice until enemy or player dead.
                break;
            case BattleStates.ENEMYCHOICE:
                // Pick move. Go to player choice until player or enemy dead.
                break;
            case BattleStates.LOSE :
                // Lose exp. Return to stage select.
                break;
            case BattleStates.WIN:
                // Gain exp. Proceed to next wave.
                break;
        }
	}
}
