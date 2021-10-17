using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class moveplatform : MonoBehaviour
{
    [SerializeField] private Vector3 temp,pos;
    public Vector3 velocity;
    private bool move=false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!move)
        {
            transform.position -= velocity * Time.deltaTime;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            move = true;
            Debug.Log("move true");
            collision.collider.transform.SetParent(transform);
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move = false;
            Debug.Log("move false");
            collision.collider.transform.SetParent(null);
        }
    }


}
