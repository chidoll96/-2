using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
