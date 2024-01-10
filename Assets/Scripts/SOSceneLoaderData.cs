using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scene Loader Data", fileName = "SceneLoaderDataAsset")]   
public class SOSceneLoaderData: ScriptableObject
{
    public string SceneNameToLoad;
    public float ProgressPercent;

    public void SetSceneNameToLoad(string sceneName)
    {
        SceneNameToLoad = sceneName;
    }

}
