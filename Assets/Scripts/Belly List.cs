using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BellyList : MonoBehaviour
{
    public BoxCollider2D[] bellyPos;
    public GameObject Gold;
    public GameObject Food;
    public GameObject Arrows;
    
    //FillBelly will instantiate items at the location of each box listed in the BoxCollider2D array "bellyPos."
    void FillBelly()
    {
        for (int i = 0; i < bellyPos.Length; i++)
        {
            int caseNum = Random.Range(0, 3);

            switch(caseNum)
            {
                case 0:
                {
                    Instantiate(Gold, new Vector3(bellyPos[i].transform.position.x, bellyPos[i].transform.position.y, bellyPos[i].transform.position.z), Quaternion.identity);
                    break;
                }
                case 1:
                {
                    Instantiate(Food, new Vector3(bellyPos[i].transform.position.x, bellyPos[i].transform.position.y, bellyPos[i].transform.position.z), Quaternion.identity);
                    break;
                }
                case 2:
                {
                    Instantiate(Arrows, new Vector3(bellyPos[i].transform.position.x, bellyPos[i].transform.position.y, bellyPos[i].transform.position.z), Quaternion.identity);
                    break;
                }
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        FillBelly();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
