using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        SceneManager.LoadScene("Quit");
    }
}