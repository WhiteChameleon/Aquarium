using UnityEngine;
using UnityEngine.SceneManagement;

public class Funicular : MonoBehaviour
{
    public GameObject objE;
    void Start()
    {
        objE.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        objE.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            PositionController.startPosition.x = -6;
            PositionController.startPosition.y = -4.2f;
            SceneManager.LoadScene("Funicular");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
