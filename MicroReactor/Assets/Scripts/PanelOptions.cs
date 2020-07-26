using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelOptions : MonoBehaviour
{
    public Button backtopanel;

    void Start()
    {
        backtopanel.onClick.AddListener(GoToMainScreen);
    }

    public void GoToMainScreen()
    {
        Debug.Log("Main Screen");
        SceneManager.LoadScene("Panel");
    }
}
