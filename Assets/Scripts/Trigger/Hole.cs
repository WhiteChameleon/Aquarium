using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSprite;
    private bool fallDown = false;
    void Update()
    {
        if (fallDown == true)
        {
            playerSprite.transform.position -= new Vector3(0, 0.1f, 0);
            if (playerSprite.transform.position.y <= -9)
            {
                PositionController.startPosition.x = 2.7f;
                PositionController.startPosition.y = -4.2f;
                SceneManager.LoadScene("UnderHome");
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            playerSprite.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
            playerSprite.transform.localScale = new Vector3(player.transform.localScale.x, player.transform.localScale.y, 0);
            player.SetActive(false);
            fallDown = true;
        }
    }
}
