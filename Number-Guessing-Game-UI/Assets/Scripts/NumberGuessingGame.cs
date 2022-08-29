using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
   [SerializedField] public int guess = 5; 
   [SerializedField] public int minValue = 1; 
   [SerializedField] public int maxValue = 10;

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
            minValue = guess; 
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is thine number higher or lower than: " + guess);
    }
    public void OnPressLower()
    {
maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is the majesty's numbah higher or lower than: " + guess);
    }
    public void NextGuess()
    {

    }
    void StartGame()
    {
        guess = 5;
        minValue = 1;
        maxValue = 10;
    
        maxValue = maxValue + 1; 
    }
}
