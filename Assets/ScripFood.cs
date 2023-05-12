using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScripFood : MonoBehaviour
{
    [field:SerializeField] public GameObject  food1;
    [field:SerializeField] public GameObject  food2;
    [field:SerializeField] public GameObject  food3;
    [field:SerializeField] public GameObject  SelectedFood;
    [field:SerializeField] public GameObject  money_ui;
    [SerializeField] public int  harga;
    public Total hitung;
    [SerializeField] TMP_Text cost;
    public Net total;
    public void SetFood(){
        food1.SetActive(false);
        food2.SetActive(false);
        food3.SetActive(false);
        total.net+=harga;
        SelectedFood.SetActive(true);
        hitung.totalbayar=hitung.totalbayar+harga;
        money_ui.SetActive(true);
    }

}
