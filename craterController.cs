using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craterController : MonoBehaviour
{
    void Start()
    {
        Invoke("OnDestroy", 2.0f);
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
