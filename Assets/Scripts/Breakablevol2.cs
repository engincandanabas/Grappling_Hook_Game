using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakablevol2 : MonoBehaviour
{
    public ParticleSystem ps;
    public Vector3 offset,offset2;
    public float speed;
    void Start()
    {
    }
    private void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.LogError("hop1");
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.LogError("hop");
            Vector3 contact = collision.contacts[0].point;
            Instantiate(ps, contact, Quaternion.identity);


            Destroy(gameObject);
        }
    }

}
