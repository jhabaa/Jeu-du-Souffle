using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballanimation : MonoBehaviour
{
    private Vector3 gravity = new Vector3(0, 0.02f, 0);
    public GameObject micVolume;
    private float moveSpeed;
    private byte balloons = 3;

    void Start()
    {
        
    }

    
    void FixedUpdate()

    {
        /* Move Cow upwards based on Mic volume */

        moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.2f;
        transform.position = new Vector3(0, transform.position.y + moveSpeed, 0);

        /* Simulate our own gravity (this one doesn't get stronger when high) */

        transform.position -= gravity;
        Debug.Log("Okk");

    }      
}


    

