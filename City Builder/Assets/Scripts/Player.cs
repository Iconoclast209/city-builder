using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Which player is this?  valid numbers 1-4
    [SerializeField] int playerNumber;

    //How many coins does this player have?  Default starting value is 3.
    [SerializeField] int coins = 3;

    //Color to help represent player in UI.
    [SerializeField] Color playerColor;

    //Landmark Status
    bool ownsTrainStation = false;
    bool ownsShoppingMall = false;
    bool ownsAmusementPark = false;
    bool ownsRadioTower = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
