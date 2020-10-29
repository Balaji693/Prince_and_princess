using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.Networking;
public class Your_Class : MonoBehaviour
{
    // Create AssetBundle variable to store the data of the bundles
    AssetBundle weapons_bundle;
    bool asset_bundles_loaded = false;

    void Start()
    {
        // Start the coroutine that will load all needed asset bundles
        StartCoroutine(load_asset_bundles());
    }

    public void Update()
    {
        // Wait for all asset bundles to be loaded
        if (asset_bundles_loaded)
        {
            // Once loaded use the assets in asset bundles
            // To get the data in  a bundle, you must do your_bundle.LoadAsset<type_of_your_asset>("name_of_the_asset_case_sensitive");
            GameObject asset_loaded_prefab = (GameObject)weapons_bundle.LoadAsset<GameObject>("Hammer");
            GameObject instance = (GameObject)GameObject.Instantiate(asset_loaded_prefab);
        }
    }

    IEnumerator load_asset_bundles()
    {
        // Reuse this line to load different asset bundles of different names
        StartCoroutine(load_sub_asset_bundle("weapons"));

        // The delay here has been added to make sure it will load.
        // Im looking into a solution to make it as quick as possible
        // but this is another problem and is not required here.
        yield return new WaitForSeconds(2F);
        asset_bundles_loaded = true;
        yield return true;
    }

    IEnumerator load_sub_asset_bundle(string bundle_name)
    {
        // This coroutine loads a single asset bundle at a time
        string uri;
        string path_to_use;

#if UNITY_ANDROID && !UNITY_EDITOR
             // This is the path to require an asset bundle in Assets/StreamingAssets on Android
             path_to_use = Path.Combine("jar:file://" + Application.dataPath + "!assets/", bundle_name);
             uri = path_to_use;
#else
        // This is the same path but for your computer to recognize
        path_to_use = Application.streamingAssetsPath;
        uri = path_to_use + "/" + bundle_name;
#endif

        // Ask for the bundle
        UnityEngine.Networking.UnityWebRequest request = UnityEngine.Networking.UnityWebRequestAssetBundle.GetAssetBundle(uri, 0);

        yield return request.Send();
        switch (bundle_name)
        {
            case "weapons":
                // Get the bundle data and store it in the AssetBundle variable created at the begining.
                weapons_bundle = DownloadHandlerAssetBundle.GetContent(request);
                break;
            default:
                break;
        }
        // Delay for now is just to make sure it loads properly before its use.
        yield return new WaitForSeconds(1F);
    }
}
