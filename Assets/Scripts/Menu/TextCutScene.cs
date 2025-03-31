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
        StartCoroutine(OutputOne("Имя Рек, знаешь, а ведь когда-то \n мир не был клочками земель по среди океана. \n Не было необходимости гадать, \n что по ту сторону воды. \n Все существа, все идеи \n были единены контуром общего берега.", 0.1f));
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
        StartCoroutine(OutputTwo("Но не нужно думать, \n что в нынешнем распаде всего - конец, \n просто сейчас сложнее увидеть связи. \n Такое уже происходило века назад. \n В те времена наши предки соединяли земли, \n плавая, в это сложно поверить, \n по воде.", 0.1f));
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
        StartCoroutine(OutputThree("Я знаю ты эти связи ещё увидишь и \n найдешь способ их донести всем. \n Пока ищи. А после... \n               \n Ты ещё споешь.", 0.1f));
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
