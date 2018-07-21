using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChildren : MonoBehaviour {
	private Transform trans;
	public Transform child;

	// Use this for initialization
	void Start () {
		trans = this.transform;
	}

	private string _IsChildOf;

	private void OnGUI() {
		if(GUILayout.Button("Detch Children"))
		{
			trans.DetachChildren();
		}
		if(GUILayout.Button("Find"))
		{
			trans.Find("Child").position = Vector3.one * 3;
		}
		if(GUILayout.Button("GetChild"))
		{
			trans.GetChild(0).position = Vector3.one * 5;
		}
		if(GUILayout.Button("_IsChildOf"))
		{
			_IsChildOf = child.IsChildOf(trans).ToString();
		}
		GUILayout.Label(_IsChildOf);
	}
}
