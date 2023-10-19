using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D rb;
    private float Xaxis;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Xaxis = Input.GetAxis("Horizontal")*Speed;
    }
    private void FixedUpdate()
    {
        Vector2 v = rb.velocity;
        v.x = Xaxis;
        rb.velocity = v;
    }
}
