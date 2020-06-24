﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private int Hitpoints = 3;
    [SerializeField] private bool RandomRotation = false;

    private void Start()
    {
        if(RandomRotation)
            transform.eulerAngles = new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - ( 8 * 2 * Time.deltaTime));

        if(transform.position.z <= -8)
        {
            Destroy(gameObject);
        }
    }
}
