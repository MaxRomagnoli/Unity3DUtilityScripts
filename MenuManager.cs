using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public void PlayLevel(string level_name)
    {
        SceneManager.LoadScene(level_name);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
