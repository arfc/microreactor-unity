using UnityEngine;

public class DoorProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToFloor1();
    }
}

