using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePlayerPref : MonoBehaviour
{
    public const string LEVEL1_FOODCOUNT_ID = "level1_foodCount";
    public const string LEVEL2_FOODCOUNT_ID = "level2_foodCount";
    public const string LEVEL3_FOODCOUNT_ID = "level3_foodCount";

    public static void SaveFoodParameter(int value)
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if(currentSceneName.Contains("Arthur"))
        {
            PlayerPrefs.SetInt(SavePlayerPref.LEVEL1_FOODCOUNT_ID, value);
            return;
        }

        if(currentSceneName.Contains("Oscar"))
        {
            PlayerPrefs.SetInt(SavePlayerPref.LEVEL2_FOODCOUNT_ID, value);
            return;
        }

        if(currentSceneName.Contains("Iris"))
        {
            PlayerPrefs.SetInt(SavePlayerPref.LEVEL3_FOODCOUNT_ID, value);
            return;
        }
    }

    public static int GetFoodParameter(string stringID)
    {
        return PlayerPrefs.GetInt(stringID);
    }
}