using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour
{
    public GameObject winText;
    IEnumerator SleepTimeout()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("MainMenu");
    }

    public void OnTriggerEnter()
    {
        winText.SetActive(true);
        StartCoroutine(SleepTimeout());
    }
}
