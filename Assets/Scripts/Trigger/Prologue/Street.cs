using UnityEngine;
using UnityEngine.SceneManagement;

public class Street : MonoBehaviour
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
            PositionController.startPosition.x = 8.6f;
            PositionController.startPosition.y = 0.4f;
            SceneManager.LoadScene("StreetTwo");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
