using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInBrokenFloor : MonoBehaviour
{
    public GameObject bttnE;
    void Start()
    {
        bttnE.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Table" && Bag.bag.Contains("Cabel"))
        {
            bttnE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                NeighborButton.numberDialog = 2;
            }
        }
        else if (coll.tag == "Player" && Bag.bag.Contains("Cabel"))
        {
            bttnE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                NeighborButton.numberDialog = 3;
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        bttnE.SetActive(false);
    }
}
