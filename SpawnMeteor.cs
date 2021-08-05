﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject meteorPrefab;

    public Vector3 center;
    public Vector3 size;

    public float frequency = 2f;

    private float offset;

    public void MeteorShower()
    {           
        InvokeRepeating("SpawnObjectMeteor", 5f, frequency);   
    }


    public void SpawnObjectMeteor()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        
        {
            Instantiate(meteorPrefab, pos, Quaternion.identity);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
    }
}
