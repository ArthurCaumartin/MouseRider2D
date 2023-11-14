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

    void Start()
    {
        Cursor.visible = true;
        print("Menu call trans");
        Transitioner.instance.DoGameTransition(true, null);
    }

    public void StartLevel(string sceneName)
    {
        Transitioner.instance.DoGameTransition(false, () =>
        {
            SceneManager.LoadScene(sceneName);
        });
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
