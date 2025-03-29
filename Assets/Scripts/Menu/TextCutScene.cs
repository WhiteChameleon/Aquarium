using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCutScene : MonoBehaviour
{
    public GameObject empty;
    [SerializeField] TMP_Text firstText;
    void Start()
    {
        empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputOne("Имя Рек, знаешь, а ведь когда-то мир не был клочками земель по среди океана. Не было необходимости гадать, что по ту сторону воды.Все существа, все идеи были единены контуром общего берега.", 0.1f));
    }
    IEnumerator OutputOne(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            yield return new WaitForSeconds(delay);
        }
        firstText.text = "";
        firstText.color = new Color32(255, 255, 255, 0);
        //empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputTwo("Но не нужно думать, что в нынешнем распаде всего - конец, просто сейчас сложнее увидеть связи. Такое уже происходило века назад. В те времена наши предки соединяли земли, плавая, в это сложно поверить, по воде.", 0.1f));
    }
    IEnumerator OutputTwo(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            yield return new WaitForSeconds(delay);
        }
        firstText.text = "";
        firstText.color = new Color32(255, 255, 255, 0);
        //empty.transform.position = new Vector3(-4, -3, 0);
        StartCoroutine(OutputThree("Я знаю ты эти связи ещё увидишь и найдешь способ их донести всем. Пока ищи. А после ты ещё споешь.", 0.1f));
    }
    IEnumerator OutputThree(string str, float delay)
    {
        foreach (var sym in str)
        {
            firstText.color += new Color32(0, 0, 0, 1);
            print(sym);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            firstText.text += sym;
            yield return new WaitForSeconds(delay);
        }
        for (int i = 51; i >= 0; i--)
        {
            firstText.color -= new Color32(0, 0, 0, 5);
            empty.transform.position += new Vector3(0, 0.01f, 0);
            yield return new WaitForSeconds(delay);
        }
        Destroy(empty);
    }
}
