using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

using Valve.VR.InteractionSystem;
public class ballanimation : MonoBehaviour
{
   // private Vector3 gravity = new Vector3(0, 0.02f, 0);
    public GameObject micVolume;
    private float moveSpeed;
    private Transform cam;
    private Vector3 gravity = new Vector3(0, 0.02f, 0);


    void Start()
    {
    }

    
    void FixedUpdate()

    {
        if (this.tag =="yellow")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.2f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
            //transform.position -= gravity;
        }
        if (this.tag == "blue")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.04f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
        }
        if (this.tag == "red")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.04f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
        }
        if (this.tag =="box")
        {
            /* Move ball based on Mic volume */

            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.2f;
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
        }

        

        /* Simulate our own gravity (this one doesn't get stronger when high) */

       // transform.position -= gravity;
      

        //on fire
       
    }     
  
}


    

