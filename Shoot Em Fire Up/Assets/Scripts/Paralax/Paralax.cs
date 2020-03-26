using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float picLength;
    private float picSpeed;
    public float parallaxSpeed;

    void Start()
    {
        //picLength = GetComponent<SpriteRenderer>().bounds.size.y;
        Debug.Log(picLength);
    }

    void Update()
    {
        picSpeed = -parallaxSpeed * Time.fixedTime;
        transform.position = new Vector2(transform.position.x, Mathf.Repeat(picSpeed, picLength));
    }
}
