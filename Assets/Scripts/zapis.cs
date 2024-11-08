using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zapis : MonoBehaviour
{
    public Slider glosnosc;
    public float poziomGlosnosci;
    public Toggle muzyka;
    public Toggle efekty;

    public Toggle HD;
    public Toggle FullHD;
    public Toggle TwoK;

    public Toggle full;

    void Start()
    {
        
    }

    
    void Update()
    {
        poziomGlosnosci = glosnosc.value;
    }

    public void koniecGryZapis()
    {
        PlayerPrefs.SetInt("fullscreen", full.isOn ? 1 : 0);
        //PlayerPrefs.SetInt("HD", HD ? 1 : 0);
        //PlayerPrefs.SetInt("FullHD", FullHD ? 1 : 0);
        //PlayerPrefs.SetInt("TwoK", HD ? 1 : 0);
        PlayerPrefs.SetInt("music", muzyka.isOn ? 1 : 0);
        PlayerPrefs.SetInt("effects", efekty.isOn ? 1 : 0);
        PlayerPrefs.SetFloat("Volume", poziomGlosnosci);
        PlayerPrefs.Save();
        Debug.Log("Koniec Gry !!");
        Application.Quit();


    }

}
