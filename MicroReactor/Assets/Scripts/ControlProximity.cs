using UnityEngine;

public class ControlProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToControlPanel();
    }
}

