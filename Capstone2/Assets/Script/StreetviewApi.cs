using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreetviewApi : MonoBehaviour
{
    public Material material;
    private double heading = 0.0;
    private double pitch = 0.0;

    string url;

    private double latitude = 37.36689;
    private double longitude = 126.8122;

    private int mapWidth = 640;
    private int mapHeight = 640;
    private Texture2D frontTex, leftTex, rightTex, backTex, upTex, downTex;
    void Start()
    {
        StartCoroutine(Map(latitude, longitude, pitch, heading));
    }
    public void StreetView(double latitude, double longitude, double pitch, double heading)
    {
        StartCoroutine(Map(latitude, longitude, 0, pitch));
        StartCoroutine(Map(latitude, longitude, 90, pitch));
        StartCoroutine(Map(latitude, longitude, 180, pitch));
        StartCoroutine(Map(latitude, longitude, 270, pitch));
        StartCoroutine(Map(latitude, longitude, heading, 90));
        StartCoroutine(Map(latitude, longitude, heading, -90));
        StartCoroutine(WaitTime());
    }
    private void SetSkyBox(Material material)
    {
        RenderSettings.skybox = material;
    }
    private Material setMaterial()
    {
        material.SetTexture("_FrontTex", frontTex);
        material.SetTexture("_BackTex", backTex);
        material.SetTexture("_LeftTex", leftTex);
        material.SetTexture("_RightTex", rightTex);
        material.SetTexture("_UpTex", upTex);
        material.SetTexture("_DownTex", downTex);
        return material;
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1f);
        Material material = setMaterial();
        SetSkyBox(material);
    }
    IEnumerator Map(double latitude, double longitude, double pitch, double heading)
    {
        url = "https://maps.googleapis.com/maps/api/streetview?" +
            "size=" + mapWidth + "x" + mapHeight +
            "&location=" + latitude + ","+ longitude +
            "&fov=" + 90 + 
            "&heading=" + heading +
            "&pitch=" + pitch +
            "&key=AIzaSyBnXl_I3__51pnLApeqG_NXzYmaI_OE07Q";

        WWW www = new WWW(url);

        yield return www;
        www.texture.wrapMode = TextureWrapMode.Clamp;
        if ((int)heading == 0)
        {
            if ((int)pitch == 0)
            {
                frontTex = www.texture;
            }
            else if ((int)pitch == 90)
            {
                upTex = www.texture;
            }
            else if ((int)pitch == -90)
            {
                downTex = www.texture;
            }
        }
        else if ((int)heading == 90)
        {
            leftTex = www.texture;
        }
        else if ((int)heading == 180)
        {
            backTex = www.texture;
        }
        else if ((int)heading == 270)
        {
            rightTex = www.texture;
        }
        Debug.Log(www.texture);
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
