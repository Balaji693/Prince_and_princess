using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BundledObjectLoader : MonoBehaviour
{
    public string assetName = "BundledSpriteObject";
    public string bundleName = "testbundle";
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle localAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));
        if(localAssetBundle == null)
        {
            Debug.LogError("failed to load assetbundle!");
            return;
        }
        GameObject asset = localAssetBundle.LoadAsset<GameObject>(assetName);
        Instantiate(asset,transform.position,transform.rotation);
        localAssetBundle.Unload(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
