using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetsBundleLearn : MonoBehaviour {
	[MenuItem("Custom Editor/Build AssetBundles")]
	static void CreateAssetBundlesMain()
	{
		BuildPipeline.BuildAssetBundles(
			"Assets/StreamingAssets",
			BuildAssetBundleOptions.None,
			targetPlatform:BuildTarget.StandaloneWindows64
		);
	}
	[MenuItem("Custom Editor/Clean Cach")]
	static void CleanCache()
	{
		Caching.ClearCache();
		Debug.LogFormat("Clean cache finished.");
	}
}
