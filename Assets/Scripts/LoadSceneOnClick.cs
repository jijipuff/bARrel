using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Loads a scene at (index param)
/// </summary>
public class LoadSceneOnClick : MonoBehaviour {

    /// <summary>
    /// Loads the index of the by.
    /// </summary>
    /// <param name="sceneIndex">Scene index.</param>
    public void LoadByIndex(int sceneIndex){
        SceneManager.LoadScene(sceneIndex);
    }


}
