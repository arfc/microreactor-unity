using UnityEngine;

public class ExitCProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ExitBuilding3();
    }
}
