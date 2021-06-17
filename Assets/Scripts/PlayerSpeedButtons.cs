using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerSpeedButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public UnityEvent ChangePlayerSpeed, RestorePlayerSpeed;
    public UnityEvent StartShoting, StopShoting;

    public void OnPointerDown(PointerEventData eventData)
    {
        ChangePlayerSpeed.Invoke();
        StartShoting.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        RestorePlayerSpeed.Invoke();
        StopShoting.Invoke();
    }
}
