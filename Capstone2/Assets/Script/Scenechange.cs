using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenechange : MonoBehaviour
{/*
    public float Lati;
    public float Longi;
    GoogleApi googleApi;
    public GameObject latlon;

    void Start()
    {
        googleApi = GameObject.Find("RawImage").GetComponent<GoogleApi>();
        Lati = googleApi.lat;
        Longi = googleApi.lon;
        DontDestroyOnLoad(gameObject);
    }
    */
    public void LoadMap()
    {
        
        SceneManager.LoadScene("map");
        //DontDestroyOnLoad(latlon);

    }
    public void LoadVRscene()
    {
        
        SceneManager.LoadScene("VRscene");
        //DontDestroyOnLoad(latlon);

    }
    public void Loadvr2()
    {
        
        SceneManager.LoadScene("vr2");
        //DontDestroyOnLoad(latlon);

    }
}
