using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorStreet : MonoBehaviour
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
            PositionController.startPosition.x = -1.5f;
            PositionController.startPosition.y = -1f;
            SceneManager.LoadScene("StartRoom");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
