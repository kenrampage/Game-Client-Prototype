using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneLoader : MonoBehaviour
{
    private string _loadingSceneName = "Loading";

    public void LoadLoadingScene()
    {
        SceneManager.LoadScene(_loadingSceneName, LoadSceneMode.Single);
    }
}
