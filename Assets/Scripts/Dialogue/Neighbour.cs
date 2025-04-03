using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Neighbour : MonoBehaviour
{
    private string[] dialogs = new string[6];
    [SerializeField] private TMP_Text nameDialog;
    [SerializeField] private TMP_Text textDialog;
    [SerializeField] private GameObject objE;
    [SerializeField] private Animator animatorSmoke;
    private int a = 0;
    private bool isTalk = false;
    private void Start()
    {
        dialogs[0] = "Ты че ещё спишь? \n Трясануло так, что я думал ласты склею. \n Вставай, карась блин.";
        dialogs[1] = "Не хочу тебя пугать, \n но хата наша на последнем исдыхании. \n Виш как балку раскочевряжило? " + @"Дом буквально ""за секунду до"". ";
        dialogs[2] = "Её бы перемотать чем-то на время. \n А там я уж поищу чем подпереть.";
        dialogs[3] = @"Вроде возле бара ""Куды""" + " валялся трос. \n Сметайся дельфинчиком, пока его не забрали с туда.";
        dialogs[4] = "Ну ты карась! Беги! \n Дом скрипит!";
        objE.SetActive(false);
    }
    private void Update()
    {
        if (isTalk)
        {
            nameDialog.text = "Помпилус";
            textDialog.text = dialogs[a];
            if (Input.GetKeyDown(KeyCode.E) && a < 4)
            {
                a++;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            objE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                animatorSmoke.SetBool("Talk", true);
                isTalk = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        isTalk = false;
        nameDialog.text = "";
        textDialog.text = "";
        animatorSmoke.SetBool("Talk", false);
        objE.SetActive(false);
    }
}