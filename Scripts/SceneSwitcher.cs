using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName; // The name of the scene to switch to

    // This method will be called when the button is clicked
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }
}
