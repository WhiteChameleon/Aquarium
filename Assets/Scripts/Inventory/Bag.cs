using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public static List<GameObject> bag; //предмет как объект
    public static List<string> item = new List<string>(); //предмет как название
    public GameObject itemsPole;
    public static int x;
    public static int y;
    void Start()
    {
        bag = new List<GameObject>();
    }
    void Update()
    {
        if (bag.Count > 0)
        {
            for (int i = 0; i < bag.Count; i++)
            {
                Instantiate(bag[i]);
                bag[i].transform.SetParent(itemsPole.transform, itemsPole);
                bag[i].transform.position = new Vector3(0, 0, 0);
                itemsPole.SetActive(false);
                bag.Clear();
            }
        }
    }
}
