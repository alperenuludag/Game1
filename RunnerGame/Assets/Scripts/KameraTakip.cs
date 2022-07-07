using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KameraTakip : MonoBehaviour
{

    public Transform karakterkonum;
    Vector3 fark;

    void Start()
    {
        fark = transform.position - karakterkonum.position;
    }

    void Update()
    {
        transform.position = karakterkonum.position + fark;
    }
}
