using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    public GameObject GameOverScreen;

    public GameObject PauseMenu;

    public GameObject QuitButton;
    public GameObject PreQuit;

    public KeyCode pauseMenu = KeyCode.P;

    private void Awake()
    {
        //when the game starts, the game over screen isn't visible
        GameOverScreen.SetActive(false);
        PauseMenu.SetActive(false);
        PreQuit.SetActive(false);
        QuitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(pauseMenu)&& LiveManager.playerLives !=0)
        {
            PauseMenu.SetActive(true);
            QuitButton.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        livesText.text = LiveManager.playerLives.ToString("Lives: " + LiveManager.playerLives);

        if (LiveManager.playerLives == 0)
        {
            GameOverScreen.SetActive (true);
            QuitButton.SetActive (true);
        }
        
    }

    public void ResetUI()
    {
        GameOverScreen.SetActive(false);
        LiveManager.playerLives = 5;
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Resume()
    {
        PauseMenu.SetActive (false);
        QuitButton.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene (sceneID);
    }

    public void PreQiutUI()
    {
        PreQuit.SetActive(true);
    }

    public void OffPreQuit()
    {
        PreQuit.SetActive (false);
    }

    public void QuitGame()
    {
        PreQuit.SetActive(false);

        QuitButton.SetActive(false);

        GameOverScreen.SetActive(false);

        PauseMenu.SetActive(false);

        SceneManager.LoadScene("MainUI");

        Time.timeScale = 1f;
       
    }

    

    


}//end
