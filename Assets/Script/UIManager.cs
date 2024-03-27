using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    public GameObject GameOverScreen;

    public GameObject PauseMenu;

    public KeyCode pauseMenu = KeyCode.P;

    private void Awake()
    {
        //when the game starts, the game over screen isn't visible
        GameOverScreen.SetActive(false);
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(pauseMenu)&& LiveManager.playerLives !=0)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        livesText.text = LiveManager.playerLives.ToString("Lives: " + LiveManager.playerLives);

        if (LiveManager.playerLives == 0)
        {
            GameOverScreen.SetActive (true);
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
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene (sceneID);
    }



}//end
