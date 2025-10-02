using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardActivate : MonoBehaviour
{
    public int handPos=-1;//flag value
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if(GameManager.instance.cardsActive)
        {
            Debug.Log("card clicked: " + handPos);
            GameManager.instance.playCard(handPos);
        }
        
    }
}
