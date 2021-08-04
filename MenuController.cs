using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadMealTracker()
    {
        SceneManager.LoadScene("MealTracker");
    }

    public void LoadFoodCategories()
    {
        SceneManager.LoadScene("FoodCategories");
    }

    public void LoadNewFoodPrompt()
    {
        SceneManager.LoadScene("NewFoodPrompt");
    }

    public void LoadEnterNewFood()
    {
        SceneManager.LoadScene("EnterNewFood");
    }

    public void LoadMealtimeNutritionScore()
    {
        SceneManager.LoadScene("MealtimeNutritionScore");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
