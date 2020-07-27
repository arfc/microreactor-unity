using UnityEngine;

public class MRProximity : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ToInfo1();
    }
}
