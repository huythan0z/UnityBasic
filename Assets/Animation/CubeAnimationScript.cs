using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeAnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("cubeAnimation", 2.0f);
        Invoke("sphereAnimation", 2.0f);
    }
    void cubeAnimation()
    {
        GameObject.Find("Cube").GetComponent<Animator>().SetBool("IsMove", true);
    }
    void sphereAnimation()
    {
        GameObject.Find("Sphere").GetComponent<Animator>().SetBool("IsSphereMove", true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
