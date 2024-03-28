using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;

public class LiveManager : MonoBehaviour
{
    public static float playerLives = 5;

    public GameObject GameWin;
    public GameObject PreQuit;
    public GameObject MenuQ;

    private PlayerMovement pm;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
        GameWin.SetActive(false);
        PreQuit.SetActive(false);
        MenuQ.SetActive(false);
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
                //Destroy(gameObject);
                Time.timeScale = 0;
            }
        }
        
        
        if (collision.gameObject.CompareTag("frag"))
        {
            //win
            GameWin.SetActive(true);
            Time.timeScale = 0f;
            MenuQ.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }

    public void PreQuitUI()//click
    {
        PreQuit.SetActive(true);
    }

    public void OffPreQuit()//no
    {
        PreQuit.SetActive(false);
    }

    public void QuitFn()//yes
    {
        SceneManager.LoadScene("MainUI");
        Time.timeScale = 1f;
    }

}//end
