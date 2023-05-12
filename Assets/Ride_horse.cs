using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ride_horse : MonoBehaviour
{   
    [field:SerializeField] public GameObject  horse_ui;
    [field:SerializeField] public GameObject  horse;
    [field:SerializeField] public GameObject  horseinmap;
    [field:SerializeField] public GameObject  mainCameraAsset;
    [SerializeField] Vector3 offset;
   public void ridde(){
        horse.SetActive(true);
        horse_ui.SetActive(true);
        horseinmap.SetActive(false);

        mainCameraAsset.transform.position+=offset;
    }
}
