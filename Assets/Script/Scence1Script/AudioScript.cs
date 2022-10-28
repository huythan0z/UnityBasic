using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource myAudio;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.clip = Resources.Load<AudioClip>("Sound/comic5-25269");
        myAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
