using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefs : MonoBehaviour
{
    public int intNum = 0;
    public float floatNum = 0f;
    public string Name = "Maksym";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PlayerPrefs.HasKey("NumInt"))
            {
                intNum = PlayerPrefs.GetInt("NumInt");
            }
            else intNum = 0;

            if (PlayerPrefs.HasKey("NumFloat"))
            {
                floatNum = PlayerPrefs.GetFloat("NumFloat");
            }
            else floatNum = 0f;

            if (PlayerPrefs.HasKey("NumString"))
            {
                Name = PlayerPrefs.GetString("NumString");
            }
            else Name = "";

            Debug.Log("Load");

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteKey("Name");

            PlayerPrefs.DeleteAll();

            PlayerPrefs.Save();
            Debug.Log("Delete");
        }
    }
}
