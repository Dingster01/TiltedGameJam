﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour {

    //public float speed = -0.5f;

    public float height = 0.0f;

    private Rigidbody2D r;

    // Use this for initialization
    void Start () { 
        r = GetComponent<Rigidbody2D>();
        r.position = new Vector2(r.position.x, height);
        //r.velocity = new Vector2(speed, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (r.position.x < -10.7)
            Destroy(gameObject);
    }
}
