#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetBundleScript : MonoBehaviour
{
    [ContextMenuItem("Assets/Build Asset Bundle")]
    static void BuildBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/assetBundles", BuildAssetBundleOptions.None, BuildTarget.Android);
    }
    
}
#endif