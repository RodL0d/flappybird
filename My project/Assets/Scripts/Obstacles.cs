using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    float speed = 3.5f;
    Rigidbody2D rigidbody2D;
    public GameObject obstacles;
    Vector2 direction, screenBounds, spriteBounds;
    SpriteRenderer spriteRender;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();

        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        spriteBounds = spriteRender.sprite.bounds.size / 2;

    }


    void Update()
    {
        if (transform.position.x >= screenBounds.x)
        {
            Destroy(obstacles);
        }
        else
        {
            rigidbody2D.velocity = direction * speed;

        }
    }
}
