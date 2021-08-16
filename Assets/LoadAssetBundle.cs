using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    AssetBundle asset;
   public  string path;
    public string bundleObject;
        
    // Start is called before the first frame update
    void Start()
    {
        LoadAssetBundle(path);
        GetObjectFromBundle(bundleObject);
    }

    private void LoadAssetBundle(string pathname)
    {
        asset = AssetBundle.LoadFromFile(pathname);
        Debug.Log(asset == null ? "Failed to Load" : "Succesful loaded");

    }
    private void GetObjectFromBundle(string objectName)
    {
        var assetPrefab = asset.LoadAsset(objectName);
        Instantiate(assetPrefab);
    }
}
