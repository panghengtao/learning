using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingGround : MonoBehaviour
{


    private Rigidbody2D rb2d;

    private Transform trans;

    private BoxCollider2D groundCollider;
    private float bgLen;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        groundCollider = GetComponent<BoxCollider2D>();

        bgLen = groundCollider.size.x;

        rb2d.velocity = new Vector2(GameController.instance.speed, 0);
    }

    void Update()
    {
        if (GameController.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
        else if (trans.position.x < -bgLen)
        {
            RpositionBackGround();
        }
    }

    private void RpositionBackGround()
    {
        Vector3 offset = new Vector3(bgLen * 2f, 0, 0);
        trans.position = trans.position + offset;
    }
}
