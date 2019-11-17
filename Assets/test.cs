using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class test : MonoBehaviour
{
    IEnumerator Request()
    {
        string url = "www.unity.com";
        WWW www = new WWW(url);
        yield return www;

        string html = www.text;
        print(html);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Request");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
