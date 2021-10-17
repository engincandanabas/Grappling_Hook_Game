using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popupmanager : MonoBehaviour
{
    public GameObject[] popups;
    private int popUpIndex = 0;
    public float waittime = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < popups.Length; i++)
        {
            if (i == popUpIndex)
            {
                popups[i].SetActive(true);
            }
            else
            {
                popups[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if (Input.GetKey(KeyCode.C))
            {
                StartCoroutine(Index(0));
            }
        }
        else if (popUpIndex == 1)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                StartCoroutine(Index(1));
            }
        }
        else if (popUpIndex == 2)
        {
            StartCoroutine(Index(2));

        }
        else if (popUpIndex == 3)
        {
            StartCoroutine(Index(3));

        }
        else if (popUpIndex == 4)
        {
            Debug.Log("bitti");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("howtoplay");
        }
        if (collision.gameObject.CompareTag("LevelPass"))
        {
            if (popUpIndex == 4)
            {
                SceneManager.LoadScene(0);
            }
           
        }
    }
    IEnumerator Index(int index)
    {
        yield return new WaitForSeconds(2);
        popUpIndex=index+1;
    }
}
