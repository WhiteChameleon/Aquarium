using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannot : MonoBehaviour
{
    public GameObject objE;
    public GameObject cannot;
    void Start()
    {
        objE.SetActive(false);
        cannot.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        objE.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            cannot.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        cannot.SetActive(false);
        objE.SetActive(false);
    }
}
