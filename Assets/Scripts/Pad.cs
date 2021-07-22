using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public float jumpAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rigidbody2D)
        {
            rigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
