using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    private float Lat;
    private float Lon ;
    SceneManage bring;
    

    private void Awake()
    {
        
    }
    private void Start()
    {
        bring = GameObject.Find("maplatlon").GetComponent<SceneManage>();
        Lat = bring.Lati;
        Lon = bring.Longi;
    }
    public void OpenURL()
    {
        Application.OpenURL("https://map.naver.com/v5/search/%EC%8B%9C%ED%9D%A5%EC%86%8C%EA%B3%B1%EC%B0%BD%20%ED%9E%88%EC%96%B4%EB%A1%9C/place/1372807044?c=14116597.9742061,4490286.3356862,15,0,0,0,dh");
    }

    public void OpenSubway()
    {
        Application.OpenURL("https://www.google.com/maps/@"+ Lat +","+Lon+",18z");
    }
}
