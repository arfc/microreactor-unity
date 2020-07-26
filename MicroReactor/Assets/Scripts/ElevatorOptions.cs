using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ElevatorOptions : MonoBehaviour
{
    public Button Floor3, Floor2, Floor1, QuitGame;

    void Start()
    {
        Floor1.onClick.AddListener(GoToFloor1);
        Floor2.onClick.AddListener(GoToFloor2);
        Floor3.onClick.AddListener(GoToFloor3);
        QuitGame.onClick.AddListener(GoToExit);
    }

    public void GoToFloor1 ()
    {
        Debug.Log("Floor1");
        SceneManager.LoadScene("Floor1");
    }

    public void GoToFloor2 ()
    {
        Debug.Log("Floor2");
        SceneManager.LoadScene("Floor2");
    }

    public void GoToFloor3 ()
    {
        Debug.Log("Floor3");
        SceneManager.LoadScene("Floor3");
    }

    public void GoToExit ()
    {
        Debug.Log("QUIT");
        SceneManager.LoadScene("Quit");
        //Application.Quit();
    }
}
