using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraWithMouse : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yah = 0.0f;
    private float pitch = 0.0f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        yah += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yah, 0.0f);
    }
}
