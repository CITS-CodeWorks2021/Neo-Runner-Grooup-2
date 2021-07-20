using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting_Platform : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {

        transform.position += transform.right * speed * Time.deltaTime;

    }
}
