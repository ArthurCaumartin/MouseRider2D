using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCounter : MonoBehaviour
{
    public int foodCount;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            foodCount++;

            FoodCheck();
        }
    }

    private void FoodCheck()
    {
        if (foodCount == 3)
        {
            Debug.Log("AllFood");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
