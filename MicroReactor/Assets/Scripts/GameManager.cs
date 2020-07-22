using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject changeLevelUI;

    public void UseElevator()
    {
        Debug.Log("Elevator");
        SceneManager.LoadScene("Elevator");
    }
}
