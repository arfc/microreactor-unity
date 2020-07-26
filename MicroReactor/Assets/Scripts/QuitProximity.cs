using UnityEngine;

public class QuitProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToQuit();
    }
}

