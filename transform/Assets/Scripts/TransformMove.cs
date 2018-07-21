using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMove : MonoBehaviour
{

    private bool moveToLeft = true;
    private float speed = 2;

    public Transform trans;

    // Use this for initialization
    void Start()
    {
        trans = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // trans.position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        // trans.localPosition = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        TransLateMove();
    }

    private void Move()
    {
        if (trans.position.x <= -3 && moveToLeft)
        {
            moveToLeft = false;
        }
        else if (trans.position.x >= 3 && !moveToLeft)
        {
            moveToLeft = true;
        }
        trans.position += (moveToLeft ? Vector3.left : Vector3.right) * Time.deltaTime * speed;
    }

    private void TransLateMove()
    {
        if (trans.position.x <= -3 && moveToLeft)
        {
            moveToLeft = false;
        }
        else if (trans.position.x >= 3 && !moveToLeft)
        {
            moveToLeft = true;
        }
        trans.Translate(transform.forward * Time.deltaTime * speed, Space.World);
    }
}
