using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabelTake : MonoBehaviour
{
    public GameObject objE;
    public GameObject self;
    public GameObject cabelItem;
    void Start()
    {
        objE.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        objE.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            Bag.bag.Add(cabelItem);
            Destroy(objE);
            Destroy(self);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }
}
