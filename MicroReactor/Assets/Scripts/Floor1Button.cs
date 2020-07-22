using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor1Button : MonoBehaviour
{
    public void Floor1()
    {
        Debug.Log("Floor1");
        SceneManager.LoadScene("Floor1");
    }
}
