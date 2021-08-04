using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MealTrackerData : MonoBehaviour
{
    public string[] mealTime = new string[] { "breakfast", "lunch", "dinner" }; //An array to store mealtimes
    public int foodCategories; //I will create a new class to store this data as I will need to create at least three lists
    public List<string> newFoodTried = new List<string>(); //A list of new food tried entered by the child/parent
}
