using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Movement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;

    }
}
