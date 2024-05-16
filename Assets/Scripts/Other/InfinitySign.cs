using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitySign : MonoBehaviour
{
    private SpriteRenderer sr;
    public AudioSource source;

    public AudioClip[] clip;

    public float speed = 1;
    public float scaleX = 5;
    public float scaleY = 5;
    public float cornerAngle = 0;
    public GameObject lifeFly;
    public GameObject deadFly;
    public GameObject killerFlyy;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        source.clip = clip[0];
        source.Play();

        deadFly.SetActive(false);
    }
    private void Update()
    {
        Flying();
    }
    private void OnMouseEnter()
    {
        StartCoroutine("FourSec", 4);
    }
    private void OnMouseExit()
    {
        StopCoroutine("FourSec");
    }
    IEnumerator FourSec(float sec)
    {
        yield return new WaitForSeconds(sec);
        source.clip = clip[1];
        deadFly.transform.position = new Vector3((lifeFly.transform.position.x), (lifeFly.transform.position.y), 0f);
        deadFly.SetActive(true);
        killerFlyy.transform.position += new Vector3(-1, 2, 0);
        Destroy(lifeFly);
        source.Play();
    }
    private void Flying()
    {
        cornerAngle += Time.deltaTime * speed;
        transform.position = new Vector3(Mathf.Cos(cornerAngle) * scaleX, Mathf.Sin(cornerAngle) * Mathf.Cos(cornerAngle) * scaleY, 0);
    }
}
