using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionButton : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load

    public void LoadDemoDayScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
