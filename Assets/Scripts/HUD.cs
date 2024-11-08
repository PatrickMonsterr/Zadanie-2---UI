using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    public Image zycie;
    private float aktualneZycie = 0.2f;
    public Animator animator;

    public Canvas hud;
   
    void Start()
    {
        
        animator.enabled = false;
       // animator2.enabled = false;
        zycie.fillAmount = aktualneZycie;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            zycie.fillAmount = aktualneZycie + 0.2f;
            aktualneZycie = zycie.fillAmount;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.enabled = true;
            Debug.Log("DZIALA???");
           animator.SetTrigger("pokazeq");
           //animator.enabled = true;

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("DZIALA???!");
            animator.SetTrigger("pokazeq2");
        

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadSceneAsync(0);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
           
            hud.gameObject.SetActive(!hud.gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            Application.Quit();
        }
    }

   
}
