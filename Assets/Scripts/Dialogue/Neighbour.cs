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
        dialogs[0] = "�� �� ��� �����? \n ��������� ���, ��� � ����� ����� �����. \n �������, ������ ����.";
        dialogs[1] = "�� ���� ���� ������, \n �� ���� ���� �� ��������� ���������. \n ��� ��� ����� ��������������? " + @"��� ��������� ""�� ������� ��"". ";
        dialogs[2] = "Ÿ �� ���������� ���-�� �� �����. \n � ��� � �� ����� ��� ���������.";
        dialogs[3] = @"����� ����� ���� ""����""" + " ������� ����. \n �������� ������������, ���� ��� �� ������� � ����.";
        dialogs[4] = "�� �� ������! ����! \n ��� �������!";
        objE.SetActive(false);
    }
    private void Update()
    {
        if (isTalk)
        {
            nameDialog.text = "��������";
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