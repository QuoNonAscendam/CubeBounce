using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class GetPost : MonoBehaviour
{
    public string json;

    public void GetByLink()
    {
        StartCoroutine(GetString());
    }
    IEnumerator GetString()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://postman-echo.com/get?foo1=bar1");
        yield return www.SendWebRequest();
        json = www.downloadHandler.text;
    }
    public void PostByLink()
    {
        StartCoroutine(PostString());
    }
    IEnumerator PostString()
    {
        List<IMultipartFormSection> wwwForm = new List<IMultipartFormSection>();
        UnityWebRequest www = UnityWebRequest.Post("https://postman-echo.com/post", json);
        yield return www.SendWebRequest();
    }
}
