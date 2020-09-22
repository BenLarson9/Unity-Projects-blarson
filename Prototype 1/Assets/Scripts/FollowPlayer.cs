using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 Offset = new Vector3(0, 7, -15);
    


   

    void Update()
    {
        transform.position = player.transform.position + Offset;
    }
}
