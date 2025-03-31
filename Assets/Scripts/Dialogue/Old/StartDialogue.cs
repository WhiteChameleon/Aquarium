using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartDialogue : MonoBehaviour
{
    public TMP_Text _text;
    public GameObject window;
    public GameObject objE;
    void Start()
    {
        _text = GetComponent<TMP_Text>();
        _text.text = "не ноль";
        window.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            window.SetActive(true);
            _text.text = "Не хочу тебя пугать, но хата наша на последнем издыхании. Вишь как балку раскочевряжило?";
            for (int i = 0; i < 5; i++)
            {
                if (Input.GetKeyUp(KeyCode.E))
                {
                    switch (i)
                    {
                        case 0:
                            _text.text = "Не хочу тебя пугать, но хата наша на последнем издыхании. Вишь как балку раскочевряжило?";
                            break;
                        case 1:
                            _text.text = "Дом буквально 'за секунду до'. ";
                            break;
                        case 2:
                            _text.text = "Её бы перемотать чем-то на время. А там я уж поищу чем подпереть.";
                            break;
                        case 3:
                            _text.text = "Вроде возле бара 'Куды' валялся трос. Сметайся дельфинчиком, пока его не забрали с туда.";
                            break;
                        case 4:
                            _text.text = "Ну ты карась! беги! Дом скрипит";
                            break;

                    }
                }
            }
        }
    }
}
