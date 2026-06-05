using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel;
    // Start is called before the first frame update
    public float jumpForce;
    public GameObject groundCheck;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        if (rb2d.velocity.magnitude < 5)
        {
            rb2d.velocity += new Vector2(vel, 0) * HorizontalInput * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }

    }
}