using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOffHorse : MonoBehaviour
{
    [field:SerializeField] public GameObject  horse_ui;
    [field:SerializeField] public GameObject  horse;
    [field:SerializeField] public GameObject  horseinmap;
    [field:SerializeField] public GameObject  mainCameraAsset;
    [SerializeField] Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
   public void GetOff()
    {
        horse.SetActive(false);
        horse_ui.SetActive(false);
        horseinmap.transform.position=mainCameraAsset.transform.position;
        horseinmap.SetActive(true);

        mainCameraAsset.transform.position+=offset;
    }
}
