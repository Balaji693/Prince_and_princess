using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    AssetBundle myLoadAssetBundle;
    public string path;
    public string prefabname;
    // Start is called before the first frame update
    void Start()
    {
        LoadAssetBundle(path);
        InstantiateObjectFromBundle(prefabname);

    }

    void LoadAssetBundle(string bundleUrl)
    {
        myLoadAssetBundle = AssetBundle.LoadFromFile(bundleUrl);
    }
    void InstantiateObjectFromBundle(string assetName)
    {
        var prefab = myLoadAssetBundle.LoadAsset(assetName);
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
