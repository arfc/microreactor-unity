using UnityEngine;
using UnityEngine.SceneManagement;

public class PSKnob : MonoBehaviour
{
    public void ToPanel()
    {
        Debug.Log("Panel");
        SceneManager.LoadScene("Panel");
    }
}
