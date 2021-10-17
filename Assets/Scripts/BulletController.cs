using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject ps;
    private GameObject yellowparticle;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        yellowparticle=Instantiate(ps, transform.position, Quaternion.identity);
        Destroy(yellowparticle,1f);
        Destroy(gameObject,.1f);
    }
}
