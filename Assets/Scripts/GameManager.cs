using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private SplineMover _containerSplineMover;

    void Awake()
    {
        instance = this;
    }

    [ContextMenu("EndLevel")]
    public void EndLevel()
    {
        _containerSplineMover._isMoving = false;

        print("Level End !");
    }

    public void PlayerHit()
    {
        print("Wow t nul...");
    }
}
