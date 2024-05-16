using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Table : MonoBehaviour
{
    public GameObject tbl;
    void Start()
    {
        tbl.SetActive(true);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            tbl.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            tbl.SetActive(true);
        }
    }
}
