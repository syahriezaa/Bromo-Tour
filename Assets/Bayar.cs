using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bayar : MonoBehaviour
{
    [SerializeField] int nominal;
    [SerializeField] int saldo;
    [SerializeField] TMP_Text sisa;
 
   public Total uang;
    void Start()
    {
        sisa.text=saldo.ToString();
    }
     public void bayar(){
        saldo=saldo-nominal;
        sisa.text=saldo.ToString();
        uang.diserahkan+=nominal;
    }
}
