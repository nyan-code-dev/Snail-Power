using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private ShellType allowedType;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DragDrop>().shellInfo.type == allowedType)
        {
            if (transform.childCount == 0)
            {
                eventData.pointerDrag.transform.SetParent(transform);
            }
        }
    }
}
