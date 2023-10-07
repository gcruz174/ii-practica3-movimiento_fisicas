using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNameOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Me he chocado con un objeto con etiqueta " + collision.gameObject.tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Me he chocado con un objeto con etiqueta " + other.gameObject.tag);
    }
}
