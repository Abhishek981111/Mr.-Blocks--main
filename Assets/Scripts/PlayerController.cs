using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigidbody2d.velocity = new Vector2(speed , 0f);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2d.velocity = new Vector2(-speed , 0f);
        }
        else if(Input.GetAxis("Vertical") > 0)
        {
            rigidbody2d.velocity = new Vector2(0f , speed);
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("Level Complete!!!");
    }
}
