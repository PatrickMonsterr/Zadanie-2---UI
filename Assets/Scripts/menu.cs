using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    [SerializeField]
    private Canvas canvasMenu;
    [SerializeField]
    private Canvas start2;
    [SerializeField]
    private Canvas sound1;
    [SerializeField]
    private Canvas screen1;
    [SerializeField]
    private Canvas manual1;
    [SerializeField]
    private Canvas exit;
    [SerializeField]
    public Toggle[] toggles;

   
    public Slider glosnosc;
    public Toggle muzyka;
    public Toggle efekty;

    public Toggle HD;
    public Toggle FullHD;
    public Toggle TwoK;

    public Toggle full;


    void Start()
    {
        //int HD1 = PlayerPrefs.GetInt("HD");
        //int FullHD1 = PlayerPrefs.GetInt("FullHD");
        //int TwoK1 = PlayerPrefs.GetInt("TwoK");


        int full1 = PlayerPrefs.GetInt("fullscreen", 1);
        int music = PlayerPrefs.GetInt("music", 1);
        int effects = PlayerPrefs.GetInt("effects", 1);
        float volume = PlayerPrefs.GetFloat("Volume", 1.0f);


         glosnosc.value = volume;
         if (music == 1)
        {
            muzyka.isOn = true;
        }
        else if (music == 0)
        {
            muzyka.isOn = false;
        }
         
         if (effects == 1)
        {
            efekty.isOn = true;
        }
         else if (effects == 0)
        {
            efekty.isOn= false;
        }

        int savedIndex = PlayerPrefs.GetInt("SelectedToggle", -1);

       
        if (savedIndex >= 0 && savedIndex < toggles.Length)
        {
           
            toggles[savedIndex].isOn = true;
        }
        else
        {
           
            toggles[0].isOn = true;
        }

        if (full1 == 1)
        {
            full.isOn = true;
        }
        else if (full1 == 0)
        {
            full.isOn= false;
        }

        //if (HD1 == 1)
        //{
        //    HD.isOn = false;
        //}
        //else if (HD1 == 0)
        //{
        //    HD.isOn = false;
        //}



        //if (FullHD1 == 1)
        //{
        //    FullHD.isOn = true;
        //}
        //else if (FullHD1 == 0)
        //{
        //    FullHD.isOn = false;
        //}

        //if (TwoK1 == 1)
        //{
        //    TwoK.isOn = true;
        //}
        //else if (TwoK1 == 0)
        //{
        //    TwoK.isOn = false;
        //}

    }
   

    public void setStart1()
    {
       start2.gameObject.SetActive(true);
       canvasMenu.gameObject.SetActive(false);
    }
    public void setManual()
    {
        canvasMenu.gameObject.SetActive(false);
        manual1.gameObject.SetActive(true);
    }

    public void setStart2()
    {
        Debug.Log("DZIALA");
        SceneManager.LoadSceneAsync(1);
    }

    public void setScreen()
    {
        canvasMenu.gameObject.SetActive(false);
        screen1.gameObject.SetActive(true);
    }

    public void setSound1()
    {
        canvasMenu.gameObject.SetActive(false);
        sound1.gameObject.SetActive(true);
    }
    public void koniec()
    {


        canvasMenu.gameObject.SetActive(false);
        exit.gameObject.SetActive(true);


    }
    public void koniecGry()
    {


        Debug.Log("Koniec Gry !!");
        Application.Quit();


    }


    public void setMenuGlowne()
    {
       
    }

    public void OnToggleClicked(Toggle clickedToggle)
    {
        if (clickedToggle.isOn)
        {
            for (int i = 0; i < toggles.Length; i++)
            {
                if (toggles[i] != clickedToggle)
                {
                    toggles[i].isOn = false;
                }
                else
                {
                    // Save the index of the selected toggle
                    PlayerPrefs.SetInt("SelectedToggle", i);
                    PlayerPrefs.Save();
                }
            }
        }
    }

    //public void OnToggleClicked(Toggle clickedToggle)
    //{

    //    if (clickedToggle.isOn)
    //    {
    //        foreach (Toggle toggle in toggles)
    //        {
    //            if (toggle != clickedToggle)
    //            {
    //                toggle.isOn = false;
    //            }
    //        }
    //    }
    //}

    public void powrot(Canvas scena)
    {
        scena.gameObject.SetActive(false);
        canvasMenu.gameObject.SetActive(true);
    }

    public void KoniecBezZapisu()
    {

        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Application.Quit();

    }
    
}
