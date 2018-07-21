using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public enum LoadMode
{
    www,
    fromFile,
}

public class TestAssets : MonoBehaviour
{
	AssetBundle asset;
    UnityEngine.Object mutObj;
	LoadMode loadMode = LoadMode.www;
    // Use this for initialization
    void Start()
    {
		Caching.ClearCache();
		Debug.Log(string.Format("persistent data path is {0}", Application.persistentDataPath.ToString()));

		switch(loadMode){
			case LoadMode.fromFile:
				asset = AssetBundle.LoadFromFile("Assets/StreamingAssets/learn.theend");
				mutObj = asset.LoadAsset("Cube");
				break;
			case LoadMode.www:
				StartCoroutine(LoadWWW("file:///F:/workspace/Learning/other/bundletest/Assets/StreamingAssets/learn.theend"));
				break;
			
		}

    }

	private void OnGUI() {
		if(GUILayout.Button("get files"))
		{
			Debug.Log("ok");
			string[] files = Directory.GetFiles(Application.dataPath);
			foreach(string fileName in files)
			{
				string f = fileName.Replace("\\", "/");
				Debug.Log(f);
				Debug.Log( fileName);
			}

			Debug.Log("---------------------------");

			string[] dirs = Directory.GetDirectories(Application.dataPath);
			foreach(string path in dirs)
			{
				int index = path.LastIndexOf("Assets");
				string p = path.Substring(index);
				Debug.Log(p);
				Debug.Log(path);
			}
		}
		
	}

    private IEnumerator LoadWWW(string path)
    {
        WWW www = WWW.LoadFromCacheOrDownload(path, 0);
		yield return www;
		if(null == www)
		{
			Debug.Log("null wwww");
			yield break;
		}

		if(!string.IsNullOrEmpty(www.error))
		{
			Debug.Log("error not found : " + www.error);
			yield break;
		}
		asset = www.assetBundle;
		mutObj = asset.LoadAsset("Cube");
    }

    // Update is called once per frame
    void Update()
    {
		// if(Input.GetMouseButton(0))
		// {
		// 	Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// 	GameObject obj = Instantiate(mutObj) as GameObject; 
		// 	Debug.Log(mutObj.name);
		// 	if(obj)
		// 	{
		// 		Debug.Log(obj.name);
		// 	}
		// 	pos.z = obj.transform.localPosition.z;
		// 	obj.transform.localPosition = pos;
		// 	obj.SetActive(true);
		// }
    }

	private void OnDestroy() {
		if(null != asset)
		{
			asset.Unload(true);
		}
	}
}
