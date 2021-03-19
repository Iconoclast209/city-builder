using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Need this to be a singleton

    // Number of Players for this game, 2-4 valid
    [SerializeField] int numberOfPlayers = 2;
    [SerializeField] int activePlayer = 0;


    
    public void StartGame()
    {
        //Determine number of players
        //Create the appropriate number of players
        for (int i = 0; i < numberOfPlayers; i++)
        {
            //Create Player
        }             

        //Set player number 1 to active
        activePlayer = 1;
    }


}
