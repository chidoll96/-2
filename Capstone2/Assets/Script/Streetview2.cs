using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Streetview2 : MonoBehaviour
{
    public RawImage img;
    
    string url;

    public float lat;
    public float lon;

    LocationInfo li;

    public int zoom = 14;
    public int mapWidth = 640;
    public int mapHeight = 640;

    public enum mapType { roadmap, satellite, hybrid, terrain }
    public mapType mapSelected;
    public int scale;

    IEnumerator Map()
    {
        url = "https://maps.googleapis.com/maps/api/staticmap?" +
            "center=" + lat + "," + lon +
            "&zoom=" + zoom +
            "&size=" + mapWidth + "x" + mapHeight +
            "&scale=" + scale +
            "&maptype=" + mapSelected +
            "&markers=color:blue%7Clabel:S%7C" + lat + "," + lon +
            "&key=AIzaSyBnXl_I3__51pnLApeqG_NXzYmaI_OE07Q";
        Debug.Log("url : " + url);

        WWW www = new WWW(url);

        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }
    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<RawImage>();
        StartCoroutine(Map());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
