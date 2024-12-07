using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Xargon : MonoBehaviour
{
    public GameObject xargon;
    public Rigidbody2D _xargonBody;
    [SerializeField]
    private float _speed = 20f;
    private float _horizontalInput;
    public GameObject pickupText;
    
    

    private void FixedUpdate()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        float horizontalMovement = _horizontalInput * _speed * Time.deltaTime;
        _xargonBody.velocity = new Vector2(horizontalMovement, _xargonBody.velocity.y);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        _xargonBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
