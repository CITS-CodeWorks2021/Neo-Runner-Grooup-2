using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Destroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;


    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    
    void Update()
    {
        Destroy(gameObject);
    }
}
