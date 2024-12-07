using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameManager gameManager;
    public Xargon xargon;
    private List<GameObject> objectsWithTriggers = new List<GameObject>();
    public GameObject pickupText;
    
    void Start ()
    {
        
        Collider[] cols = FindObjectsOfType<Collider>();

        foreach(Collider col in cols)
        {
            if(col.isTrigger)
            {
                objectsWithTriggers.Add(col.gameObject);
            }
        }
    }

    
}
