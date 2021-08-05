using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    // Floats
    public float mouseSensitivity = 100f;
    public float moveSpeed = 12f;
    public int minSeeds = 15;

    // Ints
    public int playerCollect;

    // GameObjects    
    public Transform playerBody;
    public CharacterController controller;
    private GameEnd ge;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerCollect = 0;

        ge = GameObject.FindObjectOfType(typeof(GameEnd)) as GameEnd;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * mouseX);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime);

        if(playerCollect >= minSeeds)
        {
            ge.GameWon();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Seed")
        {
            playerCollect += 1;
        }  
    }

    void OnDestroy()
    {
        Destroy(gameObject);
    }
    
}
