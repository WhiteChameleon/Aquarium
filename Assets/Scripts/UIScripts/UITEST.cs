using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITEST : MonoBehaviour
{
    public GameObject test;
    void Start()
    {
        test.SetActive(false);
    }
    void OnMouseDown()
    {
        test.SetActive(true);
    }
}
