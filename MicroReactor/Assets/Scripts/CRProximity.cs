using UnityEngine;

public class CRProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToControlRoom();
    }
}
