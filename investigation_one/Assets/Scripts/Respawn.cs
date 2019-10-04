using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Enter");
        if (col.transform.tag == "Enemy")
        {
            Debug.Log("colided with enemy");
            this.transform.position = spawnPoint.transform.position;
        }
    }
}



