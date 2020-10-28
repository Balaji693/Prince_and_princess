using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class BundleBuilder : MonoBehaviour
{
   [MenuItem("Assets/ Build AssetBundles")]  
   static void BuildAssestBundle()
    {
        BuildPipeline.BuildAssetBundles(@"D:\workspace\Prince and Princess\Assets\AssetBundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }

}
