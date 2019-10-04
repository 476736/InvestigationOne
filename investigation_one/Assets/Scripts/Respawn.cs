using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Transform PlayerTransform;

    public Transform spawnPoint;
    void Start()
    {
        PlayerTransform = GameObject.Find("Sphere").transform;
    }
    void OnTriggerEnter()
    {
        PlayerTransform.position = spawnPoint.position;
    }
}



