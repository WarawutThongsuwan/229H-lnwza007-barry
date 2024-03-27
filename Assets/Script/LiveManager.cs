using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    public static float playerLives = 5;

    private PlayerMovement pm;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
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
    }
    
    



}//end
