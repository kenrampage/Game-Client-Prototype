using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneNameToLoad;

    public bool PrintLogInsteadOfLoading = true;

    public void LoadScene()
    {
        if(PrintLogInsteadOfLoading)
        {
            Debug.Log("Loading scene " + SceneNameToLoad);
        }
        else
        {
            SceneManager.LoadScene(SceneNameToLoad, LoadSceneMode.Single);
        }
        
    }

    public void SetSceneNameToLoad(string sceneNameToLoad)
    {
       SceneNameToLoad = sceneNameToLoad;
    }
}