using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
    [Header("Force Speed")]
    public float addforce;
    public enum directions { Left, Right, Up, Bottom };
    [Header("Force Position")]
    public directions Directions;


    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Directions == directions.Left)
        {
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(-addforce, 0, 0);
        }
        else if (Directions == directions.Right)
        {
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(addforce, 0, 0);
        }
        else if (Directions == directions.Up)
        {
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(0, addforce, 0);
        }
        else
        {
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(0, -addforce, 0);
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
       // collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.forward * addforce);
    }
}
