using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuessingGame: MonoBehaviour
{
private int guess; 
   [SerializeField] private int minValue = 1; 
   [SerializeField] private int maxValue = 10;
   [SerializeField] private TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    // Update is called once per frame
    async void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Congrats we got yo numbah foo, which was " + guess + " we will take over the world!");
            Debug.Log("");
            StartGame();
        }
        
    
    }
    public void OnPressHigher()
    {
           minValue = guess + 1 ; 
           NextGuess();
    }
    public void OnPressLower()
    {
        maxValue = guess - 1 ;
        NextGuess();
    }
    public void NextGuess()
    {
        guess = Random.Range(minValue, maxValue + 1);
        // code
        guessText.text = guess.ToString();
    }
    void StartGame()
    {
     NextGuess();
    }
}  
