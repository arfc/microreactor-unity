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

    public void ExitBuilding ()
    {
        Debug.Log("Outside");
        SceneManager.LoadScene("Outside");
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
}
