using UnityEngine;

public class BuildingProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToBuilding();
    }
}
