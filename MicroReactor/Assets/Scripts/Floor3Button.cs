using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor3Button : MonoBehaviour
{
    public void Floor3()
    {
        Debug.Log("Floor3");
        SceneManager.LoadScene("Floor3");
    }
}