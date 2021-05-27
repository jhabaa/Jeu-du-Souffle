using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;
using Valve.VR.InteractionSystem;
public class ball1 : MonoBehaviour
{
    // private Vector3 gravity = new Vector3(0, 0.02f, 0);
    public GameObject micVolume;
    private float moveSpeed;
    //public GameObject fire;
    //public GameObject activeBox;

    void Start()
    {  
        // fire = GameObject.FindGameObjectWithTag("fire");
    }
    void FixedUpdate()

    {

        /* Move ball based on Mic volume */
     
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.2f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
      
        

        /* Simulate our own gravity (this one doesn't get stronger when high) */

        // transform.position -= gravity;


        //on fire

    }
}
