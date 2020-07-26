using UnityEngine;

public class ExitBProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ExitBuilding2();
    }
}
