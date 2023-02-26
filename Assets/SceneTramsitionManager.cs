using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTramsitionManager : MonoBehaviour
{
    public faderScript fadeScren;
    
    public void GoToScene(int sceneIndex){
        StartCoroutine(GoToSceneRoutine(sceneIndex));
       Debug.Log("Hello, World");

    }

    IEnumerator GoToSceneRoutine(int sceneIndex){
        fadeScren.FadeOut();
        yield return new WaitForSeconds(fadeScren.fadeDuration);
        
    SceneManager.LoadScene(sceneIndex);
    }

    //Launch new Scene

}
