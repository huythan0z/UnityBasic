using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject playerObj;
    Vector3 cameraOffset;
    //float speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("CharacterPBR");
        cameraOffset = new Vector3(0, 2, -6);
    }

    // Update is called once per frame
    void Update()
    {
        //Move Camera with mouse
        //if (Input.GetAxis("Mouse X") > 0)
        //{
        //    transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
        //                                        Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        //}
        //else if (Input.GetAxis("Mouse X") < 0)
        //{
        //    transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
        //                                        Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        //}
        transform.position = playerObj.transform.position + cameraOffset;
    }
}
