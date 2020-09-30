using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2;
    private float cooldownTime;
    
    
    
    void Update()
    {
        
        cooldownTime = cooldownTime -1 * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space) && cooldownTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldownTime = cooldown;
        }
    }
}
