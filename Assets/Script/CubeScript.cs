using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3(1, 2, 1);
        AudioSource[] audioSources = GameObject.Find("AudioFile").GetComponents<AudioSource>();
        audioSources[1].Play();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" Name is : " + collision.gameObject.name);    
    }
}
