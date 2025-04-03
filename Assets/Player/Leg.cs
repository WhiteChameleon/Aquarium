using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerScriptTest script;
    private void Update()
    {
        if (script.recIsMove)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }
}
