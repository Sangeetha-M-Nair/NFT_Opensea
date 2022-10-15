using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OpenseaApi : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private RawImage img;

    void Start()
    {
        fetchNft();
    }


    private void fetchNft()
    {
        var url = "https://testnets-api.opensea.io/api/v1/assets?collection_slug=edubai&format=json&owner=0x057264B804573f7647a264A75A09C17fB1cC25c7";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        OpenSea info = JsonUtility.FromJson<OpenSea>(json);
        //StartCoroutine(DownloadImage(info.assets[0].image_url));


        for (int i = 0; i < info.assets.Count; i++)
        {
           StartCoroutine(DownloadImage(info.assets[i].image_url));
            
            Debug.Log((info.assets[i].image_url));

        }

    }

    IEnumerator DownloadImage(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        Texture texture = DownloadHandlerTexture.GetContent(www);
        img.texture = texture;

    }

}
