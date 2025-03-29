using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BugClose : MonoBehaviour
{
    public GameObject close;
    public GameObject closesprite;
    public GameObject stop;
    public GameObject invent;
    public Animator animator;
    public Animator animatorBug;
    public Animator animatorPause;
    public void OnClick()
    {
        animatorBug.SetBool("Open", false);
        animator.SetInteger("Count", 4); //Close
        animatorPause.SetInteger("Count", 6); //Disable2
        closesprite.SetActive(false);
        close.GetComponent<Button>().interactable = false;
        stop.GetComponent<Button>().interactable = true;
        invent.GetComponent<Button>().interactable = true;
    }
}
