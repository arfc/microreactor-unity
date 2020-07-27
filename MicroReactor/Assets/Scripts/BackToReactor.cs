using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToReactor : MonoBehaviour
{
    public void ToReactor()
    {
        Debug.Log("Reactor");
        SceneManager.LoadScene("Reactor");
    }
}