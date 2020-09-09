using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   


    public float speed = 5f;
  


    void Update()
    {
        //this is dumb 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
