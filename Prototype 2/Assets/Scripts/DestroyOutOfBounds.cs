using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = -30;
    private float bottomBound = 30;


    void Update()
    {
    
        if(transform.position.x < topBound) 
        { 
            Destroy(gameObject);
        }   

    if(transform.position.x > bottomBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    
    }
}
