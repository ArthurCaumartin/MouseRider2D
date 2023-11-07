using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private GameObject _container;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        print("Game Manager call trans");
        _container = GameObject.FindGameObjectWithTag("Container");
        Transitioner.instance.DoGameTransition(true, StartLevel);
    }

    void StartLevel()
    {
        _container.GetComponent<SplineMover>().CanMove(true);
    }

    [ContextMenu("EndLevel")]
    public void EndLevel()
    {
        print("Level End !");
        _container.GetComponent<SplineMover>().CanMove(false);
        _container.GetComponentInChildren<PlayerMovements>().CanMove(false);
        Transitioner.instance.DoGameTransition(false, ReturnToMenu);
    }

    public void PlayerHit()
    {
        // print("Wow t nul...");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
