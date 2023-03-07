using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Camera should be +2.4 Y units ahead of car at all times

    [SerializeField] GameObject car;

    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3 (0, 2.4f, -10);
    }
}
