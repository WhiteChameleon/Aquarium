using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BegginingGameLoadScene : MonoBehaviour
{
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject rec;
    void Start()
    {
        StartCoroutine("FallDown", 5);
    }
    void Update()
    {
        textOne.transform.position += new Vector3(0, 0.01f, 0);
        textTwo.transform.position += new Vector3(0, 0.02f, 0);
        rec.transform.position -= new Vector3(0, 0.005f, 0);
    }
    IEnumerator FallDown(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("UnderHome");
    }
}
