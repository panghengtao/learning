using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSize : MonoBehaviour {
	private Transform trans;
	public float speed = 1;
	public bool ZoomIn = false;

	// Use this for initialization
	void Start () {
		trans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Zoom();
	}
	private void Zoom()
	{
		if(trans.localScale.x <= 0 && !ZoomIn)
		{
			ZoomIn = true;
		}
		else if(trans.localScale.x >= 3 && ZoomIn)
		{
			ZoomIn = false;
		}
		trans.localScale += (ZoomIn ? Vector3.right : Vector3.left) * Time.deltaTime * speed;
	}
}
