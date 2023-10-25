using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private Button _startGameButton;


    public void StartLevel()
    {
        SceneManager.LoadScene("BaseLevel");
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
