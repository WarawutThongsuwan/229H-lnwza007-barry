using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LiveManager : MonoBehaviour
{
    public static float playerLives = 5;

    public GameObject GameWin;
    public GameObject QuitWin;
    public GameObject QuitFn;

    private PlayerMovement pm;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
        GameWin.SetActive(false);
        QuitWin.SetActive(false);
        QuitFn.SetActive(false);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("enemy"))
        {
            playerLives --;
            if (collision.gameObject.CompareTag("ground"))
            {
                playerLives = 0;
            }
            Debug.Log(playerLives);

            if(playerLives == 0)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                
                Time.timeScale = 0;
            }
        }
        
        
        if (collision.gameObject.CompareTag("frag"))
        {
            //win
            GameWin.SetActive(true);
            Time.timeScale = 0f;
            QuitWin.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
    
    public void FinishGame()//yes
    {
        GameWin.SetActive(false);
        QuitWin.SetActive(false);
        QuitFn.SetActive(false);
        SceneManager.LoadScene("MainUI");
    }
    
    public void PreQuit()
    {
        QuitFn.SetActive(true);
    }
    
    public void OffQuitMenu()
    {
        QuitFn.SetActive(false) ;
    }

}//end
