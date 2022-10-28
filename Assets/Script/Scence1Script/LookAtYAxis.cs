using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LookAtYAxis : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject target;
    void Start()
    {
        target = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.LookAt(targetPosition);
    }
}
