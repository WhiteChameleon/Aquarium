using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeighborButton : MonoBehaviour
{
    public GameObject dialog;
    public GameObject objE;
    public DialogueStory dialogueStory;
    public static bool startdialogue;

    public static int numberDialog;
    public List<string> storyNeigbor = new List<string>();
    void Start()
    {
        dialogueStory = FindObjectOfType<DialogueStory>();
        dialog.SetActive(false);
        objE.SetActive(false);
    }
    void Update()
    {
        if (startdialogue == true)
        {
            StartDialog();
            startdialogue = false;
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            objE.SetActive(true);
            if (Input.GetKeyUp(KeyCode.E))
            {
                startdialogue = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        objE.SetActive(false);
    }

    void StartDialog()
    {
        switch (numberDialog)
        {
            case 0:
                objE.SetActive(false);
                dialog.SetActive(true);
                dialogueStory.ChangeStory(storyNeigbor[4]);// Useless
                break;
            case 1:
                objE.SetActive(false);
                dialog.SetActive(true);
                dialogueStory.ChangeStory(storyNeigbor[0]);// Start
                numberDialog = 0;
                break;
            case 2:
                dialog.SetActive(true);
                dialogueStory.ChangeStory(storyNeigbor[1]);// Table
                numberDialog = 0;
                break;
            case 3:
                dialog.SetActive(true);
                dialogueStory.ChangeStory(storyNeigbor[2]);// Hole
                numberDialog = 0;
                break;
            case 4:
                Destroy(objE);
                dialog.SetActive(true);
                dialogueStory.ChangeStory(storyNeigbor[3]);// AfterFall
                numberDialog = 0;
                break;
        }
    }
}
