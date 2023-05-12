using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Total : MonoBehaviour
{
    public int totalbayar=0;
    public int diserahkan=0;
    public XRGrabInteractable tea;
    public XRGrabInteractable coffe;
    public XRGrabInteractable susu;
    public XRGrabInteractable mie;
    public XRGrabInteractable gorengan;
    public XRGrabInteractable pop;
    [field:SerializeField] public GameObject  ui_uang;
    // Start is called before the first frame update
    
    void Start()
    {
        tea.enabled=false;
        coffe.enabled=false;
        susu.enabled=false;
        mie.enabled=false;
        gorengan.enabled=false;
        pop.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pay(){
        if (diserahkan>= totalbayar){
            tea.enabled=true;
            coffe.enabled=true;
            susu.enabled=true;
            mie.enabled=true;
            gorengan.enabled=true;
            pop.enabled=true;
            ui_uang.SetActive(false);
        }
          Debug.Log(diserahkan);
    }
}
