using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitintro : MonoBehaviour
{   
    public float waitTime;
    void Start()
    {
        StartCoroutine(waitForIntro());
    }

    IEnumerator waitForIntro()
    {

    
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Nivel1");
    }
   
}
