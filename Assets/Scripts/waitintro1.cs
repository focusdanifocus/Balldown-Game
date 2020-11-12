using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waitintro1 : MonoBehaviour
{   
    public float waitTime;
    void Start()
    {
        StartCoroutine(waitForIntro2());
    }

    IEnumerator waitForIntro2()
    {

    
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Nivel1");
    }
   
}
