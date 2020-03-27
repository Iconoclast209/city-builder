using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    // What is the name of this card?
    [SerializeField] string cardName;
    // Which Player is the Owner of this card?
    [SerializeField] int owner;
    // What die roll activates this card?
    [SerializeField] int activationValue;
    // How many coins does this card take to build?
    [SerializeField] int buildCost;
    // How many coins does this card generate
    [SerializeField] int revenueGenerated;
    // When does this card generate revenue? All turns or active player only?
    [SerializeField] bool activeOnAllTurns;
    // The picture of the card.
    Image cardImage;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
