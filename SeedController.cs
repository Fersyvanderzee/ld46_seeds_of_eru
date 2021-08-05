using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedController : MonoBehaviour
{   
    public float fallSpeedDown = 15f;
    private Rigidbody rb;

    private Collider seedCollider;

    public float rotSpeed = 15f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, -fallSpeedDown, 0);
        seedCollider = GetComponent<Collider>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(rotSpeed, rotSpeed * 2, rotSpeed * 3) * Time.deltaTime);
        if(rb.transform.position.y <= -2)
        {
            OnDestroy();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.other.gameObject.tag == "Ground")
        {
            Invoke("OnDestroy", 1f);
            seedCollider.enabled = false;

        }

        if(collision.other.gameObject.tag == "Player")
        {
            OnDestroy();
        }
    }

    void OnDestroy()
    {
        Destroy(gameObject);
    }
}
