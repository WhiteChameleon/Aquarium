using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBttn : MonoBehaviour
{
    public GameObject close;
    public GameObject closesprite;
    public GameObject stop;
    public GameObject bttn;
    public GameObject bug;
    public Animator animator;
    public Animator animatorPause;
    public Animator animatorBug;
    public GameObject itemsPole; 
    void Start()
    {
        closesprite.SetActive(false);
        close.GetComponent<Button>().interactable = false;
    }
    public void OnClick()
    {
        bug.transform.position = new Vector3(0, 0, 0);
        animator.SetInteger("Count", 3); //Disable2
        animatorPause.SetInteger("Count", 5); //Disable2
        animatorBug.SetBool("Open", true);
        closesprite.SetActive(true);
        close.GetComponent<Button>().interactable = true;
        stop.GetComponent<Button>().interactable = false;
        bttn.GetComponent<Button>().interactable = false;
        Bag.x = Random.Range(-4, 1);
        Bag.y = Random.Range(-1, 3);
        itemsPole.SetActive(true);
    }
}
