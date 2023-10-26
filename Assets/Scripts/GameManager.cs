using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }

    [ContextMenu("EndLevel")]
    public void EndLevel()
    {
        print("Level End !");
    }

    public void PlayerHit()
    {
        print("Wow t nul...");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
