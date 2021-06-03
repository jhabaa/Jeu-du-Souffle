using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

using Valve.VR.InteractionSystem;
public class ballanimation : MonoBehaviour
{
    public GameObject micVolume;
    private float moveSpeed = 0.02f;
    private Transform cam;
    private Vector3 gravity = new Vector3(0, 0.02f, 0);


    void Start()
    {
    }

    
    void FixedUpdate()

    {
        // for the mini game, we can set 3 balls. Yellow is the easiest one, then blue and red
        if (this.tag =="yellow")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.06f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
  
        }
        if (this.tag == "blue")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.03f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
        }
        if (this.tag == "red")
        {
            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.01f;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
        }
        if (this.tag =="box")
        {
           //move boxes

            moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.02f;
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y, transform.position.z);
        }
       
    }     
  
}


    

