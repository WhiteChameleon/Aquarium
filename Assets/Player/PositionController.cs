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
                PlayerScriptTest.koefficient = 0.2f;
                break;
            case "Street":
                PlayerScriptTest.koefficient = 0.1f;
                break;
            case "UnderHome":
                PlayerScriptTest.koefficient = 0.2f;
                break;
        }

        player.transform.position = new Vector3(startPosition.x, startPosition.y, 0); //��������� ������� � ����������� ������ ����� ������
    }
}