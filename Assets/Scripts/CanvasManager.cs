using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{

    public void ReplayGame()
    {
        Scene scene=SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name+"");
    }
    public void Menu(int index)
    {
        SceneManager.LoadScene(index);
    }
}
