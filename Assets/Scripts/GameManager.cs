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
        PauseLevel();
        Transitioner.instance.DoGameTransition(false, ReturnToMenu);
    }

    public void PauseLevel()
    {
        Time.timeScale = 0;
        _container.GetComponent<SplineMover>().CanMove(false);
        _container.GetComponentInChildren<PlayerMovements>().CanMove(false);
    }

    public void UnpauseLevel()
    {
        Time.timeScale = 1;
        _container.GetComponent<SplineMover>().CanMove(true);
        _container.GetComponentInChildren<PlayerMovements>().CanMove(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Finish()
    {
        _container.GetComponent<SplineMover>().CanMove(false);
        _container.GetComponentInChildren<PlayerMovements>().CanMove(false);
        CanvasManager.instance.PopWinMenu();
    }
}
