using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenTrigger : MonoBehaviour
{
    public GameObject Activator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Scrumf"))
        {
            Activator.SetActive(true);
            //gameObject.SetActive(false);
        }   
    }
}
