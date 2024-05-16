using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnClickStart()
    {
        PositionController.startPosition.z = -7;
        SceneManager.LoadScene("StartRoom");
    }
}
