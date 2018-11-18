using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGenerator : MonoBehaviour {

    public GameObject grass;

    public GameObject[] flowers;

    public float chance = 0.33f;

    public int maxflowerdelay = 3;

    public float delay = 0.5f;

    public float speed = -5f;

    private float last;

    private int lastFlower = 0;

	// Use this for initialization
	void Start () {
        last = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - last >= delay)
        {
            last = Time.time;

            GameObject gr = Instantiate(grass);
            gr.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

            if (lastFlower >= maxflowerdelay || Random.value <= chance)
            {
                int random = (int)(Random.value * (flowers.Length));

                GameObject fl = Instantiate(flowers[random]);
                fl.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

                lastFlower = 0;
            }
            else
                lastFlower++;
        }
	}
}
