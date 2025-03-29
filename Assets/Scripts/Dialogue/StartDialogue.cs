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
        _text.text = "�� ����";
        window.SetActive(false);
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            window.SetActive(true);
            _text.text = "�� ���� ���� ������, �� ���� ���� �� ��������� ���������. ���� ��� ����� ��������������?";
            for (int i = 0; i < 5; i++)
            {
                if (Input.GetKeyUp(KeyCode.E))
                {
                    switch (i)
                    {
                        case 0:
                            _text.text = "�� ���� ���� ������, �� ���� ���� �� ��������� ���������. ���� ��� ����� ��������������?";
                            break;
                        case 1:
                            _text.text = "��� ��������� '�� ������� ��'. ";
                            break;
                        case 2:
                            _text.text = "Ÿ �� ���������� ���-�� �� �����. � ��� � �� ����� ��� ���������.";
                            break;
                        case 3:
                            _text.text = "����� ����� ���� '����' ������� ����. �������� ������������, ���� ��� �� ������� � ����.";
                            break;
                        case 4:
                            _text.text = "�� �� ������! ����! ��� �������";
                            break;

                    }
                }
            }
        }
    }
}
