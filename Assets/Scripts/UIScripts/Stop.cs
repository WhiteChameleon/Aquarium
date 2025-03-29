using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop : MonoBehaviour
{
    public GameObject continuebtt;
    public GameObject pause;
    public GameObject stop;
    public GameObject invent;
    public Animator animator;
    public Animator animatorPause;
    public Animator animatorIventory;
    private void Start()
    {
        continuebtt.GetComponent<Button>().interactable = false;
    }
    public void OnClick()
    {
        animator.SetInteger("Count", 3); //Disable2
        animatorIventory.SetInteger("Count", 5); //Disable1
        animatorPause.SetInteger("Count", 1); //Open
        pause.transform.position = new Vector3(0, 0, 0);
        continuebtt.GetComponent<Button>().interactable = true;
        stop.GetComponent<Button>().interactable = false;
        invent.GetComponent<Button>().interactable = false;
    }
}
