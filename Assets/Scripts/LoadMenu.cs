using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour {

    [Tooltip("Wait time in seconds")]
    public float delay = 440;

    [Tooltip("Next scene")]
     public string NewLevel= "MainMenu";
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float d)
     {
         yield return new WaitForSeconds(d);
         SceneManager.LoadScene(NewLevel);
     }
 }
