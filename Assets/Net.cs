using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Net : MonoBehaviour
{
    [SerializeField] TMP_Text cost;
    public int net=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cost.text=net.ToString();
    }
}
