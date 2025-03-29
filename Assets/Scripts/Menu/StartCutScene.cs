using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("StartGame", 78f);
    }
    IEnumerator StartGame(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("StartRoom");
    }
}
