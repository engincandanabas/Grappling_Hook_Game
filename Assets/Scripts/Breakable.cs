using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public ParticleSystem ps;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Vector3 contact = collision.contacts[0].point;
            Instantiate(ps, contact, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
