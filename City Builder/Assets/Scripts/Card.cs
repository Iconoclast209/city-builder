using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardType {Ranch, Store, NaturalResource, Restaurant, Farm, None };


public class Card : MonoBehaviour
{
    // What is the name of this card?
    [SerializeField] string cardName;

    // What type of card is this?
    [SerializeField] CardType type;

    // Which Player is the Owner of this card? 0 = not owned
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
    [SerializeField] Image cardImage;

}
