using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int currentEnemyHealth;
    int currentPlayerHealth;
    public Text enemyHpBar;
    public Text playerHpBar;
    public Text inputBoxReader;
    public GameObject debugPanel;
    public bool cardsActive = true;

    private void Awake()
    {
        instance = this;
        updateEnemyHP(50);
        updatePlayerHP(50);
    }
    public void updateEnemyHP(int newValue)
    {
        currentEnemyHealth = newValue;
        enemyHpBar.text = "Enemy HP: " + currentEnemyHealth.ToString();
    }
    public void damageEnemy(int damageAmount)
    {
        currentEnemyHealth -= damageAmount;
        enemyHpBar.text = "Enemy HP: " + currentEnemyHealth.ToString();
    }
    public void updatePlayerHP(int newValue)
    {
        currentPlayerHealth = newValue;
        playerHpBar.text = "HP: " + currentPlayerHealth.ToString();
    }
    public void damagePlayer(int damageAmount)
    {
        currentPlayerHealth -= damageAmount;
        playerHpBar.text = "HP: " + currentPlayerHealth.ToString();
    }
    public void drawCard()
    {
        //Draw function will be called here, or we can reconfigure the button to attach to a different script
        Debug.Log("Card draw triggered");
        cardUiController.instance.generateNewCard();
    }
    public void playSelectedCard()
    {
        int num;
        if (Int32.TryParse(inputBoxReader.text,out num))//convert box to number
        {
            playCard(num);
        }
    }
    public void playCard(int cardID)
    {
        //Plays a card according to the ID currently in the ID selector box
        Debug.Log("Card " + cardID.ToString() + " play triggered");
        //Play function will be called here, or we can reconfigure the button to attach to a different script
        cardUiController.instance.removeCard(cardID);//update hand ui
    }
    public void readAndSetPlayerHP()
    {
        int num;
        if (Int32.TryParse(inputBoxReader.text, out num))
        {
            updatePlayerHP(num);
        }
    }
    public void readAndDamagePlayer()
    {
        int num;
        if (Int32.TryParse(inputBoxReader.text, out num))
        {
            damagePlayer(num);
        }
    }
    public void readAndSetEnemyHP()
    {
        int num;
        if (Int32.TryParse(inputBoxReader.text, out num))
        {
            updateEnemyHP(num);
        }
    }
    public void readAndDamageEnemy()
    {
        int num;
        if (Int32.TryParse(inputBoxReader.text, out num))
        {
            damageEnemy(num);
        }
    }
    public void toggleDebugMenu()
    {
        debugPanel.SetActive(!debugPanel.activeSelf);//toggle menu
        cardsActive = !debugPanel.activeSelf;//cards will not play from being clicked while debug menu is active
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
