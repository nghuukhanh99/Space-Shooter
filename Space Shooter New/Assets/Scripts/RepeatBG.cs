﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    private Vector3 startPos;

    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        repeatWidth = GetComponent<BoxCollider2D>().size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < startPos.y - 12.45f)
        {
            transform.position = startPos;
        }
    }
}
