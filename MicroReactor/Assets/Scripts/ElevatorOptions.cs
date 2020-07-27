using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ElevatorOptions : MonoBehaviour
{
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
        Debug.Log("ToExitPanel");
        SceneManager.LoadScene("Quit");
        //Application.Quit();
    }
}
