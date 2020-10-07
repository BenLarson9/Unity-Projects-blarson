ousing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10f;
    /*he didn't tell me how to set up positions, so i set it on the z, and for some reason, the 
    z coordinate is not centered, so i have to have 2 separate variables and im not redoing it*/
    public float zRangeup = 20;
    public float zRangdown = 0;
    public GameObject projectilePrefab;



    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);


        if (transform.position.z > 20)
           {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeup);
           }
        if(transform.position.z < 0)
           {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangdown);
           }
        if (Input.GetKeyDown(KeyCode.Space)) 
        { Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); }


    }
}
