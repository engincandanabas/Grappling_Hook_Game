using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using Cinemachine;
public class camerabutton : MonoBehaviour
{
    private bool cameraChange = false;
    public CinemachineVirtualCamera cam;
    LensSettings lens;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        lens.OrthographicSize = 10;
        lens.Dutch = 0;
        lens.NearClipPlane = 0.3f;
        lens.FarClipPlane = 1000;
        cam.m_Lens=lens;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeCameraSize()
    {
        if (!cameraChange)
        {
            ChangeCameraLensSize10();
            cameraChange = true;
        }
        else
        {
            ChangeCameraLensSize6();
            cameraChange = false;
        }
    }

    void ChangeCameraLensSize10()
    {
        while (lens.OrthographicSize < 10)
        {
            lens.OrthographicSize += (speed * Time.deltaTime);
            cam.m_Lens = lens;

        }
    }
    void ChangeCameraLensSize6()
    {
        while (lens.OrthographicSize > 6)
        {
            lens.OrthographicSize -= (speed * Time.deltaTime);
            cam.m_Lens = lens;

        }
    }
}
