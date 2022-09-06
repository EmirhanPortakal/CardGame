 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;

 public class ItemSlotUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
 {

    public GameObject InventoryPanel;
    private void Awake()
    {
       InventoryPanel.gameObject.SetActive(false);

    }

     public void OnPointerEnter(PointerEventData eventData)

     {
       //Debug.Log("mouse girdi");
       InventoryPanel.gameObject.SetActive(true);

     }

    public void OnMouseOver(PointerEventData eventData)
    {

     //InventoryPanel.gameObject.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
     //Debug.Log("mouse cikti");
     InventoryPanel.gameObject.SetActive(false);


 }
 public void OnPointerDown(PointerEventData eventData){}
 public void OnPointerUp(PointerEventData eventData){}
 private void AnalyzePointerUp(PointerEventData eventData){}
 public void OnDrag(PointerEventData eventData){}


}

