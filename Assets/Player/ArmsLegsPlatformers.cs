using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsLegsPlatformers : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerScriptPlatformer script;
    private void Update()
    {
        if (script.recIsMovePlatformer)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }
}
