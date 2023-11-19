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
        SetPlayerMove(false);
    }

    public void UnpauseLevel()
    {
        Time.timeScale = 1;
        SetPlayerMove(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    //! Call by End trigger Event
    public void Finish()
    {
        SetPlayerMove(false);
        CanvasManager.instance.PopWinMenu();
    }

    public void RestartScene()
    {
        SetPlayerMove(false);
        Transitioner.instance.DoGameTransition(false, () =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        });
    }

    void SetPlayerMove(bool value)
    {
        _container.GetComponent<SplineMover>().CanMove(value);
        _container.GetComponentInChildren<PlayerMovements>().CanMove(value);
    }
}
