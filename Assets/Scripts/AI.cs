using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, Time.deltaTime, 0f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = originalPosition;
    }
}
