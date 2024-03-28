using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIMenuGame : MonoBehaviour
{
    public GameObject MenuTutorial;
    public GameObject MenuCredit;
    public GameObject MenuQuit;
    public GameObject BGMenu;
    public GameObject TutorialF;
    public GameObject TutorialS;
    public GameObject TutorialT;

    private void Awake()
    {
        MenuTutorial.SetActive(false);
        MenuCredit.SetActive(false);
        MenuQuit.SetActive(false);
        BGMenu.SetActive(true);
        TutorialF.SetActive(false);
        TutorialS.SetActive(false); 
        TutorialT.SetActive(false);
    }


    public void TutorailSceneF()
    {
        TutorialF.SetActive(true);
        BGMenu.SetActive(false);
        MenuTutorial.SetActive(true);
        

    }

   public void TutorailSceneS()
    {
        TutorialF.SetActive(false);
        TutorialS.SetActive(true);
    }

    public void TutorialSceneT()
    {
        TutorialS.SetActive(false);
        TutorialT.SetActive(true );
    }

    public void MenuScrene()
    {
        MenuTutorial.SetActive(false);
        MenuCredit.SetActive(false);
        MenuQuit.SetActive(false);
        BGMenu.SetActive(true);
        TutorialF.SetActive(false);
        TutorialS.SetActive(false);
        TutorialT.SetActive(false);
    }

    

    public void PlayGame()
    {
        SceneManager.LoadScene("state1");
    }




    public void PreQiut()
    {
        MenuQuit.SetActive(true);
    }

    public void CreditScene()
    {
        BGMenu.SetActive(false) ;
        MenuCredit.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}//end
