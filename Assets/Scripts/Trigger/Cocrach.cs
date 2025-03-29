using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocrach : MonoBehaviour
{
    public Animator animator;
    private bool back;
    void Start()
    {
        animator.SetBool("Move", false);
    }
    void Update()
    {
        if (back == true)
        {

            if (transform.position.x >= 0 && transform.position.y >= -6.5f)
            {
                animator.SetBool("Move", false);
            }
            else
            {
                animator.SetBool("Move", true);
                transform.position -= new Vector3(-0.01f, -0.01f, 0);
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            back = false;
            animator.SetBool("Move", true);
            transform.position += new Vector3(-0.01f, -0.01f, 0);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            animator.SetBool("Move", false);
            StartCoroutine("Sec", 5);
        }
    }
    IEnumerator Sec(float sec)
    {
        yield return new WaitForSeconds(sec);
        back = true;
    }
}
