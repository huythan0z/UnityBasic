using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject playerObj;
    Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("CharacterPBR");
        cameraOffset = new Vector3(0, 2, -4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffset;
    }
}
