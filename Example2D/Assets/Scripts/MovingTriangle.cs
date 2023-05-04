using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTriangle : MonoBehaviour
{
    [SerializeField]
    private Transform pos;

    public bool triggerWorked = false;

    private void Update()
    {
        if (triggerWorked)
            Move();
    }
    private void Move()
    {
        transform.position = Vector3.Lerp(transform.position, pos.transform.position, 0.5f * Time.deltaTime); //deltaTime не зависит от частоты кадров
    }
}
