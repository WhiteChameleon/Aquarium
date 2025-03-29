using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnClickStart()
    {
        NeighborButton.numberDialog = 1;
        PositionController.startPosition.x = 1;
        PositionController.startPosition.y = -1f;
        SceneManager.LoadScene("CutScene");
    }
}
