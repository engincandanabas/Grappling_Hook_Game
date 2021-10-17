using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGameManager : MonoBehaviour
{
    public GameObject levelpaused;
    private void Awake()
    {

    }
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            levelpaused.SetActive(true);
            Time.timeScale = 0f;

        }

    }
    public void ContinueGame()
    {
        levelpaused.SetActive(false);
        Time.timeScale = 1f;

    }
}
