using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScale : MonoBehaviour {
	private void Awake() {
		Debug.Log("awake");
	}

	private void Start() {
		Debug.Log("start");
	}
	private void OnGUI() {
		GUILayout.Label(string.Format("local scale {0}", transform.localScale));
		GUILayout.Label(string.Format("loosy scale {0}", transform.lossyScale));
	}
}
