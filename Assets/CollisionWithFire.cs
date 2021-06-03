using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionWithFire : MonoBehaviour
{
    public ballanimation blowEffect;
    public Text score;
    private int compte;

    void OnCollisionEnter (Collision collision)
    {
       if (collision.collider.tag == "fire")
        {
            compte++;
            score.text = "Score : " + compte;
            Destroy(gameObject);
            
        }
        if (collision.collider.tag == "box")
        {
            blowEffect.enabled = false;
            
        }
    }
}

