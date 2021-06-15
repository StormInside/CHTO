using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerStopButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public UnityEvent ChangePlayerSpeed, RestorePlayerSpeed;

    public void OnPointerDown(PointerEventData eventData)
    {
        ChangePlayerSpeed.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        RestorePlayerSpeed.Invoke();
    }
}
