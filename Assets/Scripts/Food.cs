using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject xargon;
    public GameObject pickupText;

    public int weight = 5;
    public int wealth = 0;
    public int birds = 2;
    public int food = 5;
    
    void Awake()
    {
        xargon = GameObject.Find("Xargon");
        pickupText = GameObject.Find("PickupText");
    }
    void HeldItem(GameObject item)
    {
        transform.SetParent(item.transform);
    }
    void OnTriggerStay2D(Collider2D other)
    {
        pickupText.SetActive(true);
        print(this.gameObject.name);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HeldItem(xargon);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        pickupText.SetActive(false);
    }
}
