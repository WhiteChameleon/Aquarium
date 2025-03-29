using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyKecker : MonoBehaviour
{
    private Vector3 position;
    private Vector3 objPos;
    void Update()
    {
        position = Input.mousePosition;
        objPos = Camera.main.ScreenToWorldPoint(position);
        transform.position = new Vector3(objPos.x, objPos.y, -10);
    }
}
