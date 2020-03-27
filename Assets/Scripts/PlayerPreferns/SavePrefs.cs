using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("NumInt", 66);
        PlayerPrefs.SetFloat("NumFloat", 6.6f);
        PlayerPrefs.SetString("NumString", "Grate Games");

        PlayerPrefs.Save();
        Debug.Log("Save");
    }

    void Update()
    {

    }
}
