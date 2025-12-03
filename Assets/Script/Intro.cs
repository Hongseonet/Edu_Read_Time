using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    bool isLoading;
    int idleTime;


    void Start()
    {
        isLoading = true;
        StartCoroutine(EFEF());

        //Invoke("NextScene", 5f);
    }

    IEnumerator EFEF()
    {
        while (isLoading)
        {
            if(idleTime < 5)
            {
                SceneManager.LoadScene("Main");
            }
            yield return new WaitForSecondsRealtime(1f);
        }

        yield break;
    }
}