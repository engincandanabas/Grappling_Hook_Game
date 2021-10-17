using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerControl : MonoBehaviour
{
    [SerializeField] private GameObject levelfailed;
    [SerializeField] private GameObject levelcompleted;
    [SerializeField] private int index;
    public static bool playerdeath;
    private int mevcut_bolum;
    // Start is called before the first frame update
    void Start()
    {
        playerdeath = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("DEgdi" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Finish"))
        {
            playerdeath = true;
            levelfailed.SetActive(true);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("LevelPass"))
        {
            mevcut_bolum = PlayerPrefs.GetInt("bolum");
            if (mevcut_bolum < index + 1)
            {
                PlayerPrefs.SetInt("bolum", index + 1);
                PlayerPrefs.Save();
            }
            levelcompleted.SetActive(true);
            Destroy(gameObject, .3f);
        }
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            this.transform.parent = collision.transform;
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            playerdeath = true;
            levelfailed.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            this.transform.parent = null;
        }
    }
}
