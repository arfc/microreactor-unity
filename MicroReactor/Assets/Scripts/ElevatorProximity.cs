using UnityEngine;

public class ElevatorProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.UseElevator();
    }
}
