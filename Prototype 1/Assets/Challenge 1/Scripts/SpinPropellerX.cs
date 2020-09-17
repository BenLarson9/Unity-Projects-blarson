using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{


    public float rotateSpeed = 400;



    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
        
    }
}
