using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class allUIelements : MonoBehaviour
{
    public GameObject ui;
    void Awake()
    {
        DontDestroyOnLoad(ui);
        SceneManager.activeSceneChanged += ChangedActiveScene;
    }
    void Start()
    {
        var currentScene = SceneManager.GetActiveScene();
        ChangedActiveScene(currentScene, currentScene);
    }
    void ChangedActiveScene(Scene current, Scene next)
    {
        //ui.transform.SetParent(GameObject.Find("Canvas").transform, ui);
        Debug.Log(current.name);
        Debug.Log(next.name);
        /*if (SceneManager.GetActiveScene().name == "CutScene")
        {
            ui.SetActive(false);
            ui.transform.position = new Vector3(0, 500, 0);
        }
        else
        {
            ui.SetActive(true);
            ui.transform.position = new Vector3(0, 0, 0);
        }*/
    }
}
