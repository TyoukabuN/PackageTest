using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace YooAsset.Editor
{
    public static class YooAssetTest
    {
        [MenuItem("Test/SimulateBuildTest")]
        public static void SimulateBuildTest()
        {
            string buildPipelineName = "BuiltinBuildPipeline";
            string packageName = "DefaultPackage";
            string manifestFilePath = AssetBundleSimulateBuilder.SimulateBuild(buildPipelineName, packageName);
            Debug.Log($"[manifestFilePath]：{manifestFilePath} ");
        }
    }
}
