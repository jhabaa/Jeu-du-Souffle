using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBall : MonoBehaviour
{
    public GameObject box;
    public void AddObject()
    {
        Instantiate(box, new Vector3(Random.Range(68.0f,73.0f), 8, Random.Range(-12.0f,-17.0f)), Quaternion.identity);
    }
}
