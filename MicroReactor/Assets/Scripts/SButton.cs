using UnityEngine;
using UnityEngine.SceneManagement;

public class SButton : MonoBehaviour
{
    public void ToPanel()
    {
        Debug.Log("Panel");
        SceneManager.LoadScene("Panel");
    }
}
