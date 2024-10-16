using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        int randomNumber = Random.Range(0, 2);
        if (randomNumber == 0)
        {
            rb2d.velocity = new Vector2(1, 1) * speed;
        }
        else
        {
            rb2d.velocity = new Vector2(2, 1) * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
