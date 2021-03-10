using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Vector3 originalPosition;
    public bool clicked;
    public PlayerStats player;
    // Start is called before the first frame update
    void Start()
    {
        clicked = true;
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            transform.position += new Vector3(0f, Time.deltaTime, 0f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        clicked = false;
    }
    private void OnMouseDown()
    {
        player.TapEnemy();
        clicked = true;
        transform.position = originalPosition;
    }
}
