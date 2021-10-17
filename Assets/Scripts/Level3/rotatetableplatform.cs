using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using System;
using UnityEngine.EventSystems;
using Cinemachine;

public class rotatetableplatform : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Start()
    {

    }
    void Update()
    {

        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
