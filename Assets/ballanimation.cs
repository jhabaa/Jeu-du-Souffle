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
    private Hand hand;

    void Start()
    {
        hand = GetComponent<Hand>();
       
    }

    
    void FixedUpdate()

    {
        

        /* Move ball based on Mic volume */

        moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.2f;
        transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);

        /* Simulate our own gravity (this one doesn't get stronger when high) */

       // transform.position -= gravity;
      

        //on fire
       
    }      
}


    

