using UnityEngine;

public class Building1Proximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToBuilding1();
    }
}
