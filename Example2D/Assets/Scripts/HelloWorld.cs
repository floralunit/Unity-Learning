using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string name;
    public string description;
    public string title;

    [HideInInspector]
    public string url;

    [SerializeField]
    private string religion;
    protected int weight;


    public void Hello()
    {
        Debug.Log("Hello World!");
    }

    void Awake()
    {
        Debug.Log("Awake Sun!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Sun!");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update Sun!");
    }

    void FixedUpdate()
    {
        //Debug.Log("Fixed Update Sun!");
    }
}
