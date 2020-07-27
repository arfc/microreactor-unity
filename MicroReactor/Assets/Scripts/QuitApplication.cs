using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
    public void QuitApp()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
