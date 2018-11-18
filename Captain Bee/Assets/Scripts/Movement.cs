using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float speed;

    public GameObject player;

    public GameObject explosion;

    Rigidbody2D rb;

    private Vector2 direction;

    // Use this for initialization
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        getDirection();
        rb.MovePosition(rb.position + (direction * speed * Time.deltaTime));
    }

    void getDirection()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            direction = Vector2.up;
        if (Input.GetKey(KeyCode.A))
            direction = Vector2.left;
        if (Input.GetKey(KeyCode.S))
            direction = Vector2.down;
        if (Input.GetKey(KeyCode.D))
            direction = Vector2.right;


    }

    private void OnDestroy()
    {
        GameObject e = Instantiate(explosion);
        e.transform.position = this.transform.position;
    }
}
