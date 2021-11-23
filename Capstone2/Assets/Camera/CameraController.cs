using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CameraController : MonoBehaviour
{


    public void go()
    {
        Debug.Log("1");
    }
    // Start is called before the first frame update
    void Start()
    {
        Display.displays[1].Activate(2560, 1440, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
