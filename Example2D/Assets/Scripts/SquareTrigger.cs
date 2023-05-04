using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareTrigger : MonoBehaviour
{
    [SerializeField]
    private MovingTriangle platform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.name} встретилось с квадратом!") ;
        platform.triggerWorked = true;
    }
}
