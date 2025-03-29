using UnityEngine;
using UnityEngine.SceneManagement;

public class UnderHome : MonoBehaviour
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
            PositionController.startPosition.x = 0;
            PositionController.startPosition.y = -3.2f;
            SceneManager.LoadScene("HomeStreet");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
