using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public GameObject xargon;
    public GameObject pickupText;
    public int weight = 3;
    public int wealth = 20;
    public int arrows = 3;

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
