using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuNav : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);
    }
}
