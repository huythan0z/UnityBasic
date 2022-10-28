using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void btnOpenURL()
    {
        Application.OpenURL("https://docs.google.com/spreadsheets/d/1eCm7_IN1fJQWuuvHVhBx5yynFGbgYNGn/edit#gid=1040012847");
    }
    public void buttonTestMethod()
    {
        Debug.Log("Clickkkkk");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
