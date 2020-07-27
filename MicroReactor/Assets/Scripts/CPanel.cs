using UnityEngine;
using UnityEngine.SceneManagement;

public class CPanel : MonoBehaviour
{
    public void ToScram()
    {
        Debug.Log("Scram");
        SceneManager.LoadScene("Scram");
    }

    public void ToCRHeight()
    {
        Debug.Log("CRHeight");
        SceneManager.LoadScene("CRHeight");
    }

    public void ToPumpSpeed()
    {
        Debug.Log("PumpSpeed");
        SceneManager.LoadScene("PumpSpeed");
    }

    public void ToExit()
    {
        Debug.Log("ExitPanel");
        SceneManager.LoadScene("Control");
    }
}
