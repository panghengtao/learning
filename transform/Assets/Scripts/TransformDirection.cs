using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDirection : MonoBehaviour {
	private Transform trans;

	// Use this for initialization
	void Start () {
		trans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(trans.position, trans.TransformDirection(Camera.main.transform.forward) * 10, Color.red);
	}
}
