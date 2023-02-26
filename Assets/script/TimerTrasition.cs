using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerTrasition : MonoBehaviour
{
    [SerializeField] private float delay=10f;
    [SerializeField] private int sceneIndex;
    private  float timeElapsed;
    public faderScript fadeScren;

    IEnumerator GoToSceneRoutine(int sceneIndex){
        fadeScren.FadeOut();
        yield return new WaitForSeconds(fadeScren.fadeDuration);
        
    SceneManager.LoadScene(sceneIndex);
    }

    void Update()
    {
       timeElapsed += Time.deltaTime;

       if(timeElapsed> delay){
        StartCoroutine(GoToSceneRoutine(sceneIndex));
       }
    }
}
