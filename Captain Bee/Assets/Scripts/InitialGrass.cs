using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialGrass : MonoBehaviour {

    public float speed = -6f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
