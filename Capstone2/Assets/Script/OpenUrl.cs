using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{

    public void OpenURL()
    {
        Application.OpenURL("http://google.com/");
    }

    public void OpenSubway()
    {
        Application.OpenURL("https://www.google.com/maps/place/%EC%8D%A8%EB%B8%8C%EC%9B%A8%EC%9D%B4+%EC%88%98%EC%9B%90%EA%B2%BD%ED%9D%AC%EB%8C%80%EC%A0%90/@37.2479066,127.0773326,18z/data=!3m1!4b1!4m5!3m4!1s0x357b44dead1d1a4b:0xe06425ec1d38d9f4!8m2!3d37.2479066!4d127.0781064");
    }
}
