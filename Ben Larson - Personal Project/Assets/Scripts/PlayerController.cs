using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //you want comments huh, well heres one. 
    public float speed = 5;
    private float verticalInput;
    private float horizontalInput;
    private float boundaryX = 10;
    private float boundaryZ = 10;



    // Start is called before the first frame update(i think these are dumb)
    void Start()
    {
        
    }

    // --redacted--
    void Update()
    {
        MovePlayer();
        ConstrainPlayer();
    }
    //this here umm, ya know
    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.back * verticalInput * speed * Time.deltaTime);
    }
    //quite self explanatory am i right. so why comment, i could read the method name faster
    void ConstrainPlayer()
    {
        if (transform.position.x < -boundaryX) { transform.position = new Vector3(-boundaryX, transform.position.y, transform.position.z); }
        if (transform.position.x > boundaryX) { transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z); }
        if (transform.position.z > boundaryZ) { transform.position = new Vector3(transform.position.x, transform.position.y, boundaryZ); }
        if (transform.position.z < -boundaryZ) { transform.position = new Vector3(transform.position.x, transform.position.y, -boundaryZ); }

    }
}
