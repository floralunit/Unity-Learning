using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    [SerializeField]
    private HelloWorld helloScript;
    [SerializeField]
    private GameObject helloObj;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        // поиск по названию
        //helloScript = GameObject.Find("Sun").GetComponent<HelloWorld>();
        // поиск по тегу
        //helloScript = GameObject.FindGameObjectWithTag("firstTag").GetComponent<HelloWorld>();
        // получаем компонент, если уже имеем объект
        //helloScript = helloObj.GetComponent<HelloWorld>();
        // если компонент и скрипт висят на одном и том же объекте
        //spriteRenderer = GetComponent<SpriteRenderer>();

        helloScript.Hello();
        string _name = helloScript.name;
        Debug.Log(_name);
    }
}
