using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadThree : MonoBehaviour
{
    public void LoadScene()
    {
        CameraDesc.CameraAngles = 3;
        SceneManager.LoadScene("InvestigationOne");

    }
}
