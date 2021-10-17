using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KilitSistemi : MonoBehaviour
{
    // Start is called before the first frame update
    int mevcutbolum;
    public Button[] levellar;
    void Start()
    {
        if (!PlayerPrefs.HasKey("bolum"))
        {
            PlayerPrefs.SetInt("bolum", 1);
        }

        mevcutbolum = PlayerPrefs.GetInt("bolum");
        for (int i = 0; i < levellar.Length; i++)
        {
            if (mevcutbolum > i)
            {
                levellar[i].interactable = true;
            }
            else
            {
                levellar[i].interactable = false;
            }
        }


    }
}
