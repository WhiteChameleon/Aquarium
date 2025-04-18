using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCutScene : MonoBehaviour
{
    public GameObject empty;
    [SerializeField] TMP_Text firstText;
    private float speed = 0.006f;
    void Start()
    {
        empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputOne("��� ���, ������, � ���� �����-�� \n ��� �� ��� �������� ������ �� ����� ������. \n �� ���� ������������� ������, \n ��� �� �� ������� ����. \n ��� ��������, ��� ���� \n ���� ������� �������� ������ ������.", 0.1f));
    }
    IEnumerator OutputOne(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, speed, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, speed, 0);
            yield return new WaitForSeconds(delay);
        }
        firstText.text = "";
        firstText.color = new Color32(255, 255, 255, 0);
        //empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputTwo("�� �� ����� ������, \n ��� � �������� ������� ����� - �����, \n ������ ������ ������� ������� �����. \n ����� ��� ����������� ���� �����. \n � �� ������� ���� ������ ��������� �����, \n ������, � ��� ������ ��������, \n �� ����.", 0.1f));
    }
    IEnumerator OutputTwo(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, speed, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, speed, 0);
            yield return new WaitForSeconds(delay);
        }
        firstText.text = "";
        firstText.color = new Color32(255, 255, 255, 0);
        //empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputThree("� ���� �� ��� ����� ��� ������� � \n ������� ������ �� ������� ����. \n ���� ���. � �����... \n               \n �� ��� ������.", 0.1f));
    }
    IEnumerator OutputThree(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, speed, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, speed, 0);
            yield return new WaitForSeconds(delay);
        }
        Destroy(empty);
    }
}
