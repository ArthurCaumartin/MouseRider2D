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

    public static int[] GetFoodParameter()
    {
        int[] foodParameter = new int[3];

        foodParameter[0] = PlayerPrefs.GetInt(SavePlayerPref.LEVEL1_FOODCOUNT_ID);
        foodParameter[1] = PlayerPrefs.GetInt(SavePlayerPref.LEVEL2_FOODCOUNT_ID);
        foodParameter[2] = PlayerPrefs.GetInt(SavePlayerPref.LEVEL3_FOODCOUNT_ID);

        return foodParameter;
    }

    [ContextMenu("Reset !")]
    public void ResetPlayerPref()
    {
        PlayerPrefs.SetInt(SavePlayerPref.LEVEL1_FOODCOUNT_ID, 0);
        PlayerPrefs.SetInt(SavePlayerPref.LEVEL2_FOODCOUNT_ID, 0);
        PlayerPrefs.SetInt(SavePlayerPref.LEVEL3_FOODCOUNT_ID, 0);
    }
}