using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableFall : MonoBehaviour
{
    public GameObject tbl;
    public GameObject player;
    public GameObject playerSprite;
    public GameObject tblSprite;
    public GameObject holeBackground;

    private bool fallDown = false;
    void Start()
    {
        holeBackground.SetActive(false);
    }
    void Update()
    {
        if (fallDown == true)
        {
            holeBackground.SetActive(true);
            Debug.Log("������");
            tblSprite.transform.position -= new Vector3(0, 0.1f, 0);
            playerSprite.transform.position -= new Vector3(0, 0.1f, 0);
            if(playerSprite.transform.position.y <= -9)
            {
                SceneManager.LoadScene("BeginningGameLoad");
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Table" && Bag.bag.Contains("Cabel") && Input.GetKey(KeyCode.E))
        {
            StartCoroutine("Fall", 3);
        }
    }
    IEnumerator Fall(float sec)
    {
        player.SetActive(false);
        tbl.SetActive(false);
        tblSprite.transform.position = new Vector3(tbl.transform.position.x, tbl.transform.position.y, -18);
        playerSprite.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -18);
        Parabola.startMoving = true;
        yield return new WaitForSeconds(sec);
        fallDown = true;
    }
}