using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    AssetBundle myloadassetbundle;
    public string path;
    public string assetname;
    // Start is called before the first frame update
    void Start()
    {
        LoadAssestBundle(path);
        InstantiateObjectFromBundle(assetname);
    }

    void LoadAssestBundle(string bundleUrl)
    {
        myloadassetbundle = AssetBundle.LoadFromFile(bundleUrl);

    }
    void InstantiateObjectFromBundle(string assetname)
    {
        var prefab = myloadassetbundle.LoadAsset(assetname);
        Instantiate(prefab,transform.position,transform.rotation);
    }
}
