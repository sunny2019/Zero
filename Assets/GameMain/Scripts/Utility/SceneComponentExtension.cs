using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public static class SceneComponentExten 
{
    /// <summary>
    /// 卸载所有场景
    /// </summary>
    /// <param name="scene"></param>
    public static void UnloadAllScene(this SceneComponent scene)
    {
        string[] loadedSceneAssetNames = scene.GetLoadedSceneAssetNames();
        for (int i = 0; i < loadedSceneAssetNames.Length; i++)
        {
            scene.UnloadScene(loadedSceneAssetNames[i]);
        }
    }
}
