using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PompiliusRandomSmoke : MonoBehaviour
{
    public Animator animator;
    private int number;
    void Update()
    {
        number = Random.Range(1, 10);
        if (number > 8)
        {
            animator.SetBool("randomSmoke", true);
        }
        else
        {
            animator.SetBool("randomSmoke", false);
        }
    }
}
