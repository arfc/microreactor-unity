using UnityEngine;
using UnityEngine.SceneManagement;

public class Next2 : MonoBehaviour
{
    public void ToInfo2()
    {
        Debug.Log("Info2");
        SceneManager.LoadScene("Info2");
    }
}
