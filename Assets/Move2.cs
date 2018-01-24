﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;

    // Use this for initialization
    void Start()
    {
        min = transform.position.x - 3;
        max = transform.position.x + 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max - min) + min, transform.position.y, transform.position.z);
    }
}