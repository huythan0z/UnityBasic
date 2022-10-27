using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBroadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 playerPositionUp = transform.position;
            playerPositionUp.z += 0.1f;
            transform.position = playerPositionUp;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 playerPositionDown = transform.position;
            playerPositionDown.z += -0.1f;
            transform.position = playerPositionDown;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 playerPositionRight = transform.position;
            playerPositionRight.x += 0.1f;
            transform.position = playerPositionRight;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 playerPositionLeft = transform.position;
            playerPositionLeft.x += -0.1f;
            transform.position = playerPositionLeft;
        }

    }
}
