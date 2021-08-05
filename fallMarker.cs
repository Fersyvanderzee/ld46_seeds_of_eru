using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallMarker : MonoBehaviour
{

    public GameObject fallMarkerPrefab;
    private Vector3 fallDirection = Vector3.down;
    private GameObject fallMarkerInstance = null;
    public float targetTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        if(Physics.Raycast(new Ray(transform.position, fallDirection), out hit))
        {
            Vector3 fallPosition = hit.point;
            fallMarkerInstance = Instantiate(fallMarkerPrefab, fallPosition - 0.05f * fallDirection, Quaternion.identity);
            
            if(transform.position.y < 0.5f)
            {
                Destroy(fallMarkerInstance);
            }
            Invoke("OnDestroy", targetTime);
        }
    }

    private void OnDestroy()
    {
        Destroy(fallMarkerInstance);
    }

}
