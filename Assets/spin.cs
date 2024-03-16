using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class spin : MonoBehaviour
{
    float speed = 3f;
    System.Random r = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0f, 0.1f, 0f, Space.Self);
    }
}
