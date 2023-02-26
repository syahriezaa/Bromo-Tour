using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripFood : MonoBehaviour
{
    [field:SerializeField] public GameObject  food1;
     [field:SerializeField] public GameObject  food2;
    [field:SerializeField] public GameObject  food3;
     [field:SerializeField] public GameObject  SelectedFood;

    public void SetFood(){
        food1.SetActive(false);
        food2.SetActive(false);
        food3.SetActive(false);

        SelectedFood.SetActive(true);
    }

}
