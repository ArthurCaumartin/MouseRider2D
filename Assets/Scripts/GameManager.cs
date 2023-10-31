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

    void Start()
    {
        print("Game Manager call trans");
        Transitioner.instance.DoGameTransition(true, null);
    }

    [ContextMenu("EndLevel")]
    public void EndLevel()
    {
        print("Level End !");
        Transitioner.instance.DoGameTransition(false, ReturnToMenu);
    }

    public void PlayerHit()
    {
        print("Wow t nul...");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
