using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseClose : MonoBehaviour
{
    public GameObject continuebtt;
    public GameObject stop;
    public GameObject invent;
    public Animator animator;
    public Animator animatorPause;
    public Animator animatorIventory;
    public void OnClick()
    {
        animator.SetInteger("Count", 4); //Disable1
        animatorPause.SetInteger("Count", 2); //Disable1
        animatorIventory.SetInteger("Count", 6); //Disable1
        continuebtt.GetComponent<Button>().interactable = false;
        stop.GetComponent<Button>().interactable = true;
        invent.GetComponent<Button>().interactable = true;
    }
}
