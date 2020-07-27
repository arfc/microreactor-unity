using UnityEngine;
using UnityEngine.SceneManagement;

public class CRKnob : MonoBehaviour
{
    public void ToPanel()
    {
        Debug.Log("Panel");
        SceneManager.LoadScene("Panel");
    }
}
