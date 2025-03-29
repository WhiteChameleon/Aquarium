using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionController : MonoBehaviour
{
    public GameObject player;
    public static Vector3 startPosition;
    private Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        switch (scene.name) //���������� �������������� ��������� � ����������� �� �����
        {
            case "StartRoom":
            case "Home":
            case "Bar":
            case "Funicular":
            case "UnderHome":
                PlayerScriptTest.koefficient = 0.2f;
                break;
            case "Street":
            case "HomeStreet":
                PlayerScriptTest.koefficient = 0.1f;
                break;
        }

        player.transform.position = new Vector3(startPosition.x, startPosition.y, 0); //��������� ������� � ����������� ������ ����� ������
    }
}
