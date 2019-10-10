using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoadTwo : MonoBehaviour
{
    public void LoadScene()
    {
        CameraDesc.CameraAngles = 2;
        SceneManager.LoadScene("InvestigationOne");

    }
}