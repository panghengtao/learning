using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotation : MonoBehaviour {
	private void Awake() {
		Debug.Log("rotation awake");
	}
	private void Start() {
		Debug.Log("rotation start");
	}
	private void OnGUI() {
		GUILayout.Label(string.Format("Transform eulerAngle: {0}", transform.eulerAngles));
		GUILayout.Label(string.Format("Transform local eulerAngle: {0}", transform.localEulerAngles));
		GUILayout.Label(string.Format("Transform rotation: {0}", transform.rotation));
		GUILayout.Label(string.Format("Transform rotation: {0}", transform.localRotation));
	}
}
