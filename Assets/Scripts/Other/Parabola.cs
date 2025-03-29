using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola : MonoBehaviour
{
    public GameObject rec;
    public float koef;
    public float speed;
    public static bool startMoving;
    void Update()
    {
        if (startMoving == true)
        {
            StartMove();
        }
        Move();
        StopMove();
    }
    void StartMove()
    {
        speed = 0.05f;
        if (rec.transform.position.x > 0)
        {
            speed = speed * -1;
        }
        koef = 3 / Mathf.Pow(rec.transform.position.x, 2);
        startMoving = false;
    }
    void Move()
    {
        transform.position += new Vector3(speed, -(rec.transform.position.y), 0);
        transform.position = new Vector3(rec.transform.position.x, -(Mathf.Pow(rec.transform.position.x, 2)) * koef + 1.6f, -20);
    }
    void StopMove()
    {
        if (speed < 0)
        {
            if (rec.transform.position.x <= 0)
            {
                Destroy(this);
            }
        }
        else if (speed > 0)
        {
            if (rec.transform.position.x >= 0)
            {
                Destroy(this);
            }
        }
        else
        {
            return;
        }
    }
}
