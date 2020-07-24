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

    public void ToBuilding()
    {
        Debug.Log("Building");
        SceneManager.LoadScene("Building");
    }
}
