using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float initialSpeed = 2f;
    public float jumpHeight = 10f;
    public bool isGrounded = false;


    private void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        transform.position += transform.right * initialSpeed * Time.deltaTime;
    }

    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
            }

        }
    }

}