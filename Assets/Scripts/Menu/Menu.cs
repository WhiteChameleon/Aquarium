using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] AudioSource guitarStringSound;
    public void OnClickStart()
    {
        NeighborButton.numberDialog = 1;
        PositionController.startPosition.x = 1;
        PositionController.startPosition.y = -1f;
        StartCoroutine("StartGame", 5);
    }
    public void OnClickBttn()
    {
        guitarStringSound.Play();
    }
    public void OnExit()
    {
        guitarStringSound.Play();
        Application.Quit();
    }
    IEnumerator StartGame()
    {
        guitarStringSound.Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("CutScene");
    }
}
