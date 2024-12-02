using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputHandler : MonoBehaviour
{
   [SerializeField] Scrumf playerChar;
    void Awake()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;
        if(Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1,0,0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1,0,0);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            movement += new Vector3(0,1,0);
        }


        playerChar.Move(movement);
    }
}
