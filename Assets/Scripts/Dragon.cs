using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public GameObject dragon;
    public SpriteRenderer dragonSprite;
    public float dragonColor = 1f;
    
    public GameObject Xargon;
    // Start is called before the first frame update
    void Start()
    {
        dragonSprite = dragon.GetComponent<SpriteRenderer>();
        dragonColor = dragonSprite.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (Xargon.transform.localPosition.x > -2)
        {
            SkinFade(true);
            
        }
        else
        {
            SkinFade(false);
            
        }
        
        
    }
        

    void SkinFade(bool inside)
    {
        
        if (inside)
        {
            float fade = Mathf.MoveTowards(1, 0, Time.deltaTime/10);
            dragonColor -= fade;
            dragonSprite.color += new Color(0, 0, 0, dragonColor);
            if(dragonColor <= 0.1){dragon.SetActive(false);}

            
        }
        else
        {
            dragon.SetActive(true);
            float fade = Mathf.MoveTowards(0, 1, Time.deltaTime/10);
            dragonColor += fade;
            dragonSprite.color += new Color(0, 0, 0, dragonColor);
        }
        
    }
}
