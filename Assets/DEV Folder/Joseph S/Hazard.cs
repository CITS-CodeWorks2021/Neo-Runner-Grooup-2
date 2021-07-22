using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hazard : MonoBehaviour
{
    public static UnityEvent OnStruck = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        if(collision.gameObject.tag == "Player") {
            OnStruck.Invoke();
        }
    }
}
