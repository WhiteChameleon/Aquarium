using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPlatformer : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerScriptPlatformer script;
    void Update()
    {
        int number = Random.Range(1, 10);
        if (number > 7)
        {
            animator.SetBool("breath", true);
        }
        else
        {
            animator.SetBool("breath", false);
        }
        if (script.recIsMovePlatformer)
        {
            BodyRotation(10f);
        }
        else
        {
            BodyRotation(0f);
        }
    }
    private void BodyRotation(float targetRotation)
    {
        Quaternion tilt = Quaternion.Euler(0, 0, targetRotation * script.slantPlatformer);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, tilt, 5f * Time.deltaTime);
    }
}
