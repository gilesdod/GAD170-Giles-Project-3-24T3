using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = Unity.Mathematics.Random;

public class CartList : MonoBehaviour
{

    public BoxCollider2D[] bags;
    public List<GameObject> cartList = new List<GameObject>();

    void UIUpdate(int listPos)
    {
        cartList[listPos].transform.localPosition = bags[listPos].transform.localPosition;
    }
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D[] bags = FindObjectsOfType<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
