using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithFire : MonoBehaviour
{
    public ballanimation blowEffect;

    void OnCollisionEnter (Collision collision)
    {
       if (collision.collider.tag == "fire")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "box")
        {
            blowEffect.enabled = false;
            
        }
    }
}

