﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirsPrefabBehaiviour : MonoBehaviour
{
    [Range(0f, 100f)]
    [SerializeField]
    private float speed = 1f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up*speed;

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
