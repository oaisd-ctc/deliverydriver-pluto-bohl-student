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
    [SerializeField] int slowSpeed = 10;
    [SerializeField] float boostSpeed = 17.5f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float accelerateAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, accelerateAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }

    int numberBoosts = 0;

    private void OnTriggerEnter2D(Collider2D bump) {
        if (bump.tag == "Boost" && numberBoosts == 0)
        {
            moveSpeed = boostSpeed;
        } else if (bump.tag == "Boost" && numberBoosts >= 1 && numberBoosts <= 5)
        {
            numberBoosts++;
            moveSpeed = moveSpeed + 2.5f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
}