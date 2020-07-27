using UnityEngine;
using UnityEngine.SceneManagement;

public class Next3 : MonoBehaviour
{
    public void ToInfo3()
    {
        Debug.Log("Info3");
        SceneManager.LoadScene("Info3");
    }
}