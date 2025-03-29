using UnityEngine;

public class TableScale : MonoBehaviour
{
    private float koefficient;
    private float yPos, diff;
    void Start()
    {
        yPos = transform.position.y;
        koefficient = 0.15f;
    }

    void Update()
    {
        diff = yPos - transform.position.y;
        yPos = transform.position.y;
        transform.localScale += new Vector3(diff * koefficient, diff * koefficient, 0);
    }
}
