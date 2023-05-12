using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_picture : MonoBehaviour
{
    [field:SerializeField] public GameObject  CameraCover;
    [field:SerializeField] public GameObject  flash;
    [field:SerializeField] public GameObject  camera_ui;
    [SerializeField] private float delay;
    [SerializeField] AudioSource CameraSoud;
    private  float timeElapsedd;

    void Start()
    {   
     
    }

     public void Take(){
        StartCoroutine(take_picture());
    }

    public IEnumerator take_picture(){
        camera_ui.SetActive(false);
        CameraCover.SetActive(true);
        yield return new WaitForSeconds(3);
        flash.SetActive(true);
        CameraSoud.Play(); 
        yield return new WaitForSeconds(0.1F);
        flash.SetActive(false);
        yield return new WaitForSeconds(1);
        CameraCover.SetActive(false);
        camera_ui.SetActive(true);
    }
}
