using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caseInFire : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
    
            Destroy(collision.collider);
      
    }
}
