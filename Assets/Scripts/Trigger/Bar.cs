using UnityEngine;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
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
            PositionController.startPosition.x = -7.5f;
            PositionController.startPosition.y = -1.8f;
            SceneManager.LoadScene("Bar");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
