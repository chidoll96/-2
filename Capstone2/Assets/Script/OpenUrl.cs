using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{

    public void OpenURL()
    {
        Application.OpenURL("http://google.com/");
    }
}
