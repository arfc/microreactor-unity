using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject changeLevelUI;

    public void UseElevator ()
    {
        Debug.Log("Elevator");
        SceneManager.LoadScene("Elevator");
    }

    public void ExitBuilding1 ()
    {
        Debug.Log("OutsideA");
        SceneManager.LoadScene("OutsideA");
    }

    public void ExitBuilding2()
    {
        Debug.Log("OutsideB");
        SceneManager.LoadScene("OutsideB");
    }

    public void ExitBuilding3()
    {
        Debug.Log("OutsideC");
        SceneManager.LoadScene("OutsideC");
    }

    public void ToControlRoom ()
    {
        Debug.Log("Control Room");
        SceneManager.LoadScene("Control");
    }

    public void ToBuilding1()
    {
        Debug.Log("Building1");
        SceneManager.LoadScene("Building1");
    }

    public void ToBuilding2()
    {
        Debug.Log("Building2");
        SceneManager.LoadScene("Building2");
    }

    public void ToControlPanel ()
    {
        Debug.Log("Panel");
        SceneManager.LoadScene("Panel");
    }

    public void ToFloor1 ()
    {
        Debug.Log("Floor1");
        SceneManager.LoadScene("Floor1");
    }

    public void ToFloor1B()
    {
        Debug.Log("Floor1B");
        SceneManager.LoadScene("Floor1B");
    }

    public void ToQuit ()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene("Quit");
    }
}
