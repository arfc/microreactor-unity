using UnityEngine;

public class ExitProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ExitBuilding();
    }
}
