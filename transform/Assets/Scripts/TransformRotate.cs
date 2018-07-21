using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : MonoBehaviour
{
    public Transform trans;
    float speed = 10;

    // Use this for initialization
    void Start()
    {
        trans = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        // trans.localEulerAngles = new Vector3(0, 0, 45);
        // trans.eulerAngles = new Vector3(0, 0, 45);

        // trans.rotation = Quaternion.Euler(0, 0, 45);

        // trans.eulerAngles += Vector3.forward * Time.deltaTime * speed;
        // Rotate();
        // LoodAt();
		ChangeDir();
    }

    public Transform target;

    private void Rotate()
    {
        // trans.Rotate(Vector3.forward * Time.deltaTime * speed);
        trans.RotateAround(target.position, target.up, Time.deltaTime * speed);
    }

    private void LoodAt()
    {
        trans.LookAt(target);
    }

    private void ChangeDir()
    {
        Vector3 dir = trans.position - target.position;
        trans.up = dir;
    }
}
