using UnityEngine;

public class Building2Proximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToBuilding2();
    }
}
