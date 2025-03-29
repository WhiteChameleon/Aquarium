using UnityEngine;
using UnityEngine.SceneManagement;

public class FunicularBack : MonoBehaviour
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
            PositionController.startPosition.x = 5.2f;
            PositionController.startPosition.y = -0.3f;
            SceneManager.LoadScene("HomeStreet");
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
