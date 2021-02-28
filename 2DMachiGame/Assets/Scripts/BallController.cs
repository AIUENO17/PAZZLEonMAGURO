using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BallController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler

{

    private bool IsTouch = false;

    RectTransform RectTransform;

    private void Awake()
    {
        RectTransform = this.GetComponent<RectTransform>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (IsTouch)
        {
            RectTransform.position = Input.mousePosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        IsTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsTouch = false;
    }


}