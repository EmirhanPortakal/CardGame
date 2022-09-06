using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TreasureSlot : MonoBehaviour, IPointerDownHandler
{
    GameManager gm;
    private void Start()
    {
       gm = FindObjectOfType<GameManager>(); 
    }
    public void OnPointerDown(PointerEventData eventData){
        gm.DrawCard();
    }
    
}
