using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using Cinemachine;
public class CameraLens : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    LensSettings lens;
    [SerializeField] private float speed;
    private bool cameraChange = false;
    void Start()
    {
        lens.OrthographicSize = 6;
        lens.Dutch = 0;
        lens.NearClipPlane = 0.3f;
        lens.FarClipPlane = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            if (lens.OrthographicSize < 10)
            {
                lens.OrthographicSize +=(speed * Time.deltaTime);
            }
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            lens.OrthographicSize = 6;
        }
        cam.m_Lens = lens;*/
        if (Input.GetKeyDown(KeyCode.C))
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
