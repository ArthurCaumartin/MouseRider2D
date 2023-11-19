using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager instance;
    [SerializeField] private Transform _winMenu;
    [SerializeField] private float _winMenuAnimationDuration;
    [SerializeField] private List<Image> _menuFoodImage;
    public List<Image> FoodImageList = new List<Image>();
    public List<Destroy_Food> FoodList = new List<Destroy_Food>();

    void Awake()
    {
        instance = this;
    }

    public void PopWinMenu()
    {
        _winMenu.gameObject.SetActive(true);
        _winMenu.localScale = Vector3.zero;
        _winMenu.DOScale(Vector3.one, _winMenuAnimationDuration);
    }

    public void ScoreUPdateFood(Destroy_Food caller)
    {
        int index = 0;
        for (int i = 0; i < FoodList.Count; i++)
        {
            if (caller == FoodList[i])
            {
                index = i;
                break;
            }
        }
        FoodImageList[index].color = Color.yellow;
        _menuFoodImage[index].color = Color.yellow;
    }

    public void StartFoodColorSwitch()
    {
        for (int i = 0; i < FoodImageList.Count; i++)
        {
            FoodImageList[i].GetComponent<ColorSwitch>().switchColor = true;
        }
    }

    public void ReplayLevel()
    {
        GameManager.instance.RestartScene();
    }

    public void GoToMenu()
    {
        Transitioner.instance.DoGameTransition(false, () =>
        {
            SceneManager.LoadScene("MenuScene");
        });
    }
}
