using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor2Button : MonoBehaviour
{
    public void Floor2()
    {
        Debug.Log("Floor2");
        SceneManager.LoadScene("Floor2");
    }
}

