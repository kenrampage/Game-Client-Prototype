using Obvious.Soap;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //[SerializeField] private SOSceneLoaderData _sceneLoaderData;
    [SerializeField] private StringVariable _sceneNameToLoad;

    private string _loadingSceneName = "Loading";
    private bool allowSceneActivation = false;

    public UnityEvent OnLoadComplete;

    public void LoadScene()
    {
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        Debug.Log(_sceneNameToLoad.Value);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_sceneNameToLoad.Value, LoadSceneMode.Single);
        asyncLoad.allowSceneActivation = false;

        while (!allowSceneActivation)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
            //_sceneLoaderData.ProgressPercent = progress;

            if (asyncLoad.progress >= 0.9f)
            {
                OnLoadComplete?.Invoke();
            }

            yield return null;
        }

        asyncLoad.allowSceneActivation = true;
   
    }


    public void LoadLoadingScene()
    {
        SceneManager.LoadScene(_loadingSceneName, LoadSceneMode.Single);
    }

    public void AllowSceneActivation()
    {
        allowSceneActivation = true;
    }

}