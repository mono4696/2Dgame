using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 pos;
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed = 2f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            speed = -2f;
        }
        else
        {
            speed = 0f;
        }
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "E_Bullet")
        {
            Destroy(gameObject);

        }
    }
}
