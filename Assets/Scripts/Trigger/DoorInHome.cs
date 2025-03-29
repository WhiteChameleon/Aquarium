using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInHome : MonoBehaviour
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
            PositionController.startPosition.x = -3.7f;
            PositionController.startPosition.y = -4.4f;
            SceneManager.LoadScene("HomeStreet");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
