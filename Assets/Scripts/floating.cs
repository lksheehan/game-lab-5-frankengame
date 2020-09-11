using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    [Header("Forces")]
    public float forwardSpeed = 3.0f;
    public float upForce = 75.0f;

    [Header("Movement")]   
    public Rigidbody2D Rb;
    public float Speed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("FixedUpdate", 3.0f);
    }

    void FixedUpdate()
    {
        float hsp = Speed;

        Vector2 newVelocity = rb.velocity;
        newVelocity.x = forwardSpeed;
        rb.velocity = newVelocity;


        bool upActive = Input.GetKey(KeyCode.Mouse0);
        if (upActive)
        {
            rb.AddForce(new Vector2(0, upForce));
        }

        if (Input.GetKey("left"))
        {
            forwardSpeed = -3.0f;
        }

        if (Input.GetKey("right"))
        {
            forwardSpeed = 3.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Spike")
        {
            this.gameObject.SetActive(false);
        }
    }

}
