using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
   public int guess = 5; 
   public int minValue = 1; 
   public int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    // Update is called once per frame
    async void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess; 
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is thine number higher or lower than: " + guess);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is the majesty's numbah higher or lower than: " + guess);
            
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Congrats we got yo numbah foo, which was " + guess + " we will take over the world!");
            Debug.Log("");
            StartGame();
        }
        
    
    }

    void StartGame()
    {
        guess = 5;
        minValue = 1;
        maxValue = 10;
         Debug.Log("Welcome to our Numbah Guessing Game.");
        Debug.Log("The number range is from " + minValue + " and " + maxValue);
        Debug.Log("Guess a Number Using The Arrow Keys");
        Debug.Log("Push Up arrow = Higher, Push Down arrow = Lower, Push enter = Correct");
        Debug.Log("Tell me if your number is higher or lower : " + guess + "?");
        maxValue = maxValue + 1; 
    }
}
