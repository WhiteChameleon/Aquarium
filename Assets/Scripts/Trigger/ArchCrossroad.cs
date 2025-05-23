using UnityEngine;
using UnityEngine.SceneManagement;

public class ArchCrossroad : MonoBehaviour
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
            PositionController.startPosition.x = 1.5f;
            PositionController.startPosition.y = -0.8f;
            SceneManager.LoadScene("HomeStreet");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
