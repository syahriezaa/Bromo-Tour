using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneColider : MonoBehaviour
{
    public faderScript fadeScren;
    [SerializeField] int SIndex;
    
    public void OnTrigger(Collider other){
        StartCoroutine(GoToSceneRoutine(SIndex));

    }

    IEnumerator GoToSceneRoutine(int sceneIndex){
        fadeScren.FadeOut();
        yield return new WaitForSeconds(fadeScren.fadeDuration);
        
    SceneManager.LoadScene(sceneIndex);
    }

}
