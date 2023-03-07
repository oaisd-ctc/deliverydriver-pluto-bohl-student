using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int steerSpeed = 200;
    [SerializeField] float moveSpeed = 13.50f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float accelerateAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, accelerateAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}