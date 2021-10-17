using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static SingletonMusic music=null;
    void Awake()
    {
        if (music == null)
        {
            music = this;
            DontDestroyOnLoad(this);
        }
        else if (this != music)
        {
            Destroy(gameObject);
        }
    }
}
