using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject playerToSpawn;

    public void SpawnPlayer()
    {
        Instantiate(playerToSpawn);
    }





}//end
