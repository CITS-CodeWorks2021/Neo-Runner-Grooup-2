using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TestHazard : MonoBehaviour
{
    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        Hazard.OnStruck.AddListener(HandelOnStruck); 
    }

    private void HandelOnStruck()
    {
       
            gameObject.SetActive(isOn);
        isOn = !isOn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
