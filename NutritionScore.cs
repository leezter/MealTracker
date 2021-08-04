using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NutritionScore : MonoBehaviour
{
    public Text mealtimeNutritionScore; // The mealtime nutrition score to be displayed as text in the 'MealtimeNutritionScore' scene.
    public Text dailyNutriitionScore; //The daily nutrition score to be displayed as text in the 'DailyNutritionScore' scene.
    public static int score = 0;    // An integer that will be used for the score. I declared it as static and gave it a value of 0 so that it 
                                    //gets reset to 0 each time the application is restarted.
    private int scorePerClick = 1; //An integer that will be used to increment the value of score each time a food category button is clicked

    public Text newFoodEntered;     // A Text variable that will be used to get the text that is entered into the input field. 
    public static string addFoodToList; //A string that will be used for adding the input entered by the user to a string which can later be store in a list.

    public void Start()
    {
        //I Struggled to get the final score to display because the 
        //Unity scene that displays the score was not activing this script. I
        //soon realised that I needed to use the Unity MonoBehaviour function 
        //'Start()' int order to activate the script when that scene is displayed.

        mealtimeNutritionScore.text = score.ToString();
    }

    public void CalculateNutritionScore()
    {
        score += scorePerClick;
        PlayerPrefs.SetInt("score", score);
        Debug.Log("The current score is " + score);
    }

    public void AddNewFood()
    {
        string newFood = newFoodEntered.text.ToString();
        addFoodToList = newFood;
        Debug.Log("New food entered is " + addFoodToList);

    }
}
