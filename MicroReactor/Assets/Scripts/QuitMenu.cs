using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitMenu : MonoBehaviour
{
    public Button quitgame;

    void Start()
    {
        quitgame.onClick.AddListener(GoToQuit);
    }

    public void GoToQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}