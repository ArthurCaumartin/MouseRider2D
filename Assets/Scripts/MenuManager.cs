using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [Space]
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _quitButton;


    void Start()
    {
        //TODO Set les refs
        _startGameButton.onClick.AddListener(StartLevel);
        _quitButton.onClick.AddListener(QuitGame);
    }

    void StartLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    void DisableAll()
    {
        _mainMenu.SetActive(false);
    }

    public void SetMenu()
    {
        DisableAll();
        _mainMenu.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
