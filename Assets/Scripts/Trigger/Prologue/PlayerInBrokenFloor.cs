using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInBrokenFloor : MonoBehaviour
{
    public GameObject bttnE;
    public GameObject tbl;
    void Start()
    {
        bttnE.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (Bag.bag.Count > 0)
        {
            Pit();
        }
    }
    void Pit()
    {
        if (tbl.transform.position.x > -1 && Bag.bag.Count > 0)
        {
            Debug.Log("стол есть");
            bttnE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                NeighborButton.startdialogue = true;
                NeighborButton.numberDialog = 2;
            }
        }
        else if (Bag.bag.Count > 0)
        {
            Debug.Log("стола нет");
            bttnE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                NeighborButton.startdialogue = true;
                NeighborButton.numberDialog = 3;
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        bttnE.SetActive(false);
    }
}
