using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("YOU HIT SOMETHING!");
    }

    bool hasPackage = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package") {
            Debug.Log("Picked Up A Package.");
            hasPackage = true;
        }
        
        if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package Delivered.");
            hasPackage = false;
        }
    }
}
