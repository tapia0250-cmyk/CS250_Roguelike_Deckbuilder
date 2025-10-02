using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardUiController : MonoBehaviour
{
    public static cardUiController instance;
    public GameObject card;
    GameObject[] cardsHand = new GameObject[10];//max hand size makes this easier, I set it to 10
    int handPosTracker = 0;
    


    public void generateNewCard()
    {
        
        if (handPosTracker>9) { return; }//enforce max hand size
        Debug.Log("New card created in hand " + handPosTracker);
        cardsHand[handPosTracker] = Instantiate(card);//create and store new card
        cardsHand[handPosTracker].GetComponent<cardActivate>().handPos = handPosTracker;
        handPosTracker++;
        arrangeCards();
    }

    void arrangeCards()
    {
        float cardOffset;//calculate this later
        float cardBegin;//calculate later
        if (handPosTracker < 7) { cardOffset = 2.5f; cardBegin = cardOffset / -2 * (handPosTracker-1); }
        else { cardOffset = (float)(15.0 / (handPosTracker-1)); cardBegin = -7.5f; }
        for (int i=0;i<handPosTracker;i++)
        {
            cardsHand[i].GetComponent<Rigidbody2D>().MovePosition(new Vector2(cardBegin + cardOffset * i,-3f));
            Debug.Log("repositioned card " + i + " to x=" + cardBegin + cardOffset * i);
        }
    }

    public void removeCard(int cardNum)
    {
        if (cardNum>=handPosTracker||cardNum<0)
        {
            return;//specified card does not exist in UI
        }
        Destroy(cardsHand[cardNum]);
        for (int i=cardNum+1;i<handPosTracker;i++)
        {
            cardsHand[i].GetComponent<cardActivate>().handPos--;
            cardsHand[i - 1] = cardsHand[i];
            cardsHand[i] = null;
        }
        handPosTracker--;
        arrangeCards();
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        generateNewCard();
        */
    }
    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
