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
        // ����� �� ��������
        //helloScript = GameObject.Find("Sun").GetComponent<HelloWorld>();
        // ����� �� ����
        //helloScript = GameObject.FindGameObjectWithTag("firstTag").GetComponent<HelloWorld>();
        // �������� ���������, ���� ��� ����� ������
        //helloScript = helloObj.GetComponent<HelloWorld>();
        // ���� ��������� � ������ ����� �� ����� � ��� �� �������
        //spriteRenderer = GetComponent<SpriteRenderer>();

        helloScript.Hello();
        string _name = helloScript.name;
        Debug.Log(_name);
    }
}
