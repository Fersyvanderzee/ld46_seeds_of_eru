using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int playerCollect = 0;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Seed")
        {
            playerCollect += 1;
            Debug.Log(playerCollect);
        }
    


    }
}