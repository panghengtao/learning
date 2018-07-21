using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnGUI() {
		GUILayout.Label(string.Format("transform's position : {0}", transform.position));
		GUILayout.Label(string.Format("transform's local position : {0}", transform.localPosition));
	}
	
}
