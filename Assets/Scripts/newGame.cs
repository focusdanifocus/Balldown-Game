using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip Empezar;
    public float WaitTimeLoad;

    public void loadnewGame()
    {
        StartCoroutine(waitforLoad());
    }

    public void StartSound(){
        mySounds.PlayOneShot(Empezar);
        DontDestroyOnLoad(Empezar);
    }
    IEnumerator waitforLoad()
    {

    
        yield return new WaitForSeconds(WaitTimeLoad);
        SceneManager.LoadScene("Nivel1");
    
        
    }
}
