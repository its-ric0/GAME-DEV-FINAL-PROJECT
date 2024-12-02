using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemTrigger : MonoBehaviour
{
    public GameObject Activator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Scrumf"))
        {
            Activator.SetActive(false);
            //gameObject.SetActive(false);
        }   
    }
}
