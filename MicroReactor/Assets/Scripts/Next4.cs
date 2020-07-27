using UnityEngine;
using UnityEngine.SceneManagement;

public class Next4 : MonoBehaviour
{
    public void ToInfo4()
    {
        Debug.Log("Info4");
        SceneManager.LoadScene("Info4");
    }
}