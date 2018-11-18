using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    //public float speed = -0.5f;

    public float height = 0.0f;

    private Rigidbody2D r;

    private ParticleSystem ps;

    private bool exploded = false;

    [SerializeField]
    private float increaseTime = 5;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        r.position = new Vector2(r.position.x, height);
        //r.velocity = new Vector2(speed, 0);

       ps = GetComponent<ParticleSystem>();
       ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (r.position.x < -10.7)
            Destroy(gameObject);
    }

    void Explode()
    {
        if(!exploded)
        {
            exploded = true;
            ps.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("GameplayController").GetComponent<Timer>().time += increaseTime;
            Explode();
        }
    }
}
