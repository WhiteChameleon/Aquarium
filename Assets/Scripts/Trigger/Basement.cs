using UnityEngine;
using UnityEngine.SceneManagement;

public class Basement : MonoBehaviour
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
            PositionController.startPosition.x = -6.3f;
            PositionController.startPosition.y = -3.6f;
            SceneManager.LoadScene("UnderHome");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
