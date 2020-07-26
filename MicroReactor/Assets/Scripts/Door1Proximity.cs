using UnityEngine;

public class Door1Proximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToFloor1B();
    }
}

