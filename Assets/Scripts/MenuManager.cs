using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _levelSelect;
    [SerializeField] private Button _startGameButton;

    public void StartLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetMenu()
    {
        DisableAll();
        _mainMenu.SetActive(true);
    }

    public void SetLevelSelect()
    {
        DisableAll();
        _levelSelect.SetActive(true);
    }

    void DisableAll()
    {
        _mainMenu.SetActive(false);
        _levelSelect.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
