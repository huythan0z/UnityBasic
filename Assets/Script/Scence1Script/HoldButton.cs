using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldButton : MonoBehaviour
{
    // Start is called before the first frame update
    bool isFiring;
    bool stopFiring;
    void Start()
    {
        
    }

    public void pointerDown()
    {
        stopFiring = false;
        makeFireVariableTrue();
    }
    public void pointerUp()
    {
        isFiring = false;
        stopFiring = true;
    }
    void makeFireVariableTrue()
    {
        isFiring = true;    
    }
    void makeFireVariableFalse()
    {
        isFiring = false;
        if (stopFiring == false)
        {
            Invoke("makeFireVariableTrue", 0.5f);
        }
    }
    void Update()
    {
        if (isFiring)
        {
            Debug.Log("Fireeeeeee");
        }
    }
}
