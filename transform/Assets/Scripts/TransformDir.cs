using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDir : MonoBehaviour
{
    private void OnGUI()
    {
        GUILayout.Label(string.Format("transform right: {0}", transform.right));
        GUILayout.Label(string.Format("transform up: {0}", transform.up));
        GUILayout.Label(string.Format("transform forward: {0}", transform.forward));
        GUILayout.Label(string.Format("transform childcount: {0}", transform.childCount));
        GUILayout.Label(string.Format("transform parent name: {0}", transform.parent.name));
        GUILayout.Label(string.Format("transform root name: {0}", transform.root.name));
    }
}
