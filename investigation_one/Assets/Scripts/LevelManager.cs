using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    GameObject sideScrollerCam;
    GameObject thirdPersonCam;
    GameObject firstPersonCam;
    Movement playerMovement;
    TFPMovement playerMovementTwo;

    void Start()
    {

        sideScrollerCam = GameObject.Find("SideScrollerCam");
        thirdPersonCam = GameObject.Find("ThirdPersonCam");
        firstPersonCam = GameObject.Find("FirstPersonCam");

        //1 = sidescroller
        if (CameraDesc.CameraAngles == 1)
        {
            thirdPersonCam.SetActive(false);
            firstPersonCam.SetActive(false);
            playerMovementTwo = GameObject.Find("Sphere").GetComponent<TFPMovement>();
            playerMovementTwo.enabled = false;
        }
        else if(CameraDesc.CameraAngles == 2)
        {
            sideScrollerCam.SetActive(false);
            firstPersonCam.SetActive(false);
            playerMovement = GameObject.Find("Sphere").GetComponent<Movement>();
            playerMovement.enabled = false;


        }
        else if (CameraDesc.CameraAngles == 3)
        {
            sideScrollerCam.SetActive(false);
            thirdPersonCam.SetActive(false);
            playerMovement = GameObject.Find("Sphere").GetComponent<Movement>();
            playerMovement.enabled = false;
        }
    }
}
