using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody objRigitBody;
    Animator aniCharacter;
    float speed = 5.0f;
    void Start()
    {
        aniCharacter = GetComponent<Animator>();
        objRigitBody = transform.GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            aniCharacter.SetBool("Run", false);
            aniCharacter.SetBool("Stop", true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            aniCharacter.SetBool("Stop", false);
            aniCharacter.SetBool("Run", true);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //objRigitBody.AddForce(new Vector3(0, 0, 1), ForceMode.VelocityChange);
            //aniCharacter.SetTrigger("Run");
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objRigitBody.AddForce(new Vector3(0, 1, 0), ForceMode.VelocityChange);
        }

    }
}
