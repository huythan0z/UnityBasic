using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    // Start is called before the first frame update
    public Planet attractorPlanet;
    private Transform playerTransform;
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }
    private void FixedUpdate()
    {
        if (attractorPlanet)
        {
            attractorPlanet.Attract(playerTransform);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
