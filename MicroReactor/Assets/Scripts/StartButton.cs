using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void ToOutside()
    {
        Debug.Log("OutsideA");
        SceneManager.LoadScene("OutsideA");
    }
}
