using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsUI : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator.SetInteger("Count", 0); //Disable1
    }
    void OnMouseEnter()
    {
        animator.SetInteger("Count", 1); ; //Press
    }
    public void OnClick()
    {
        animator.SetInteger("Count", 3); //Disable2
    }
    void OnMouseExit()
    {
        animator.SetInteger("Count", 2); //Close
    }
}
