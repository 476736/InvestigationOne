﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoad : MonoBehaviour
{
    public void LoadScene()
    {
        CameraDesc.CameraAngles = 1;
        SceneManager.LoadScene("InvestigationOne");
        
    }
}
