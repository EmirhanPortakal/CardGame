using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CurseCardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler



{
    public CardCurse cardcurse;
    public Image illustration5, image;
    public TextMeshProUGUI cardName5, prerequisite,curseeffects;
    private Transform originalParent5;
   private void Awake()
   {
    image = GetComponent<Image>();
   


   }  
  private  void Start()
    {
      



        
    }
 public void Initialize(CardCurse cardcurse)
 {
  this.cardcurse = cardcurse; 

 illustration5.sprite = cardcurse.illustration5;
 cardName5.text = cardcurse.cardName5;
prerequisite.text = cardcurse.prerequisite;
 curseeffects.text = cardcurse.curseeffects;
 originalParent5 = transform.parent;



 }
   public void OnPointerEnter(PointerEventData eventData)
   {
    
   }
   public void OnMouseOver(PointerEventData eventData){
    Debug.Log("mouse girdi");
   }
   public void OnPointerExit(PointerEventData eventData)
   {
    

   }
 public void OnPointerDown(PointerEventData eventData)
 {
  if(originalParent5.name == $"PlayableArea2")
  {

  }
  else 
  {
    transform.SetParent(transform.root);
  image.raycastTarget = false;


  }
  
 }
 public void OnPointerUp(PointerEventData eventData)
 {
   Debug.Log(eventData.pointerEnter);
  image.raycastTarget = true;
  AnalyzePointerUp(eventData);

 
 }

 private void AnalyzePointerUp(PointerEventData eventData)
   {  
    
    if(eventData.pointerEnter != null && eventData.pointerEnter.name == $"PlayableArea2")
    
    {
      if(PlayerManager.instance.FindPlayerByID(cardcurse.ownerID).movemana >= cardcurse.cardMovemana)
      {
        PlayCard(eventData.pointerEnter.transform);
        Debug.Log(eventData.pointerEnter.transform);

      }
      else  
      {
        ReturnToHand();

      }
    }
    else
    {
      ReturnToHand();

    }

    

   }
   private void PlayCard(Transform playArea)
   {
    transform.SetParent(playArea);
    originalParent5 = playArea;
    transform.localPosition = Vector3.zero; 



   }


   public void PlayCardClass()
   {

   }

   public void ReturnToHand()
   {
    transform.SetParent(originalParent5);
    transform.localPosition = Vector3.zero; 


   }

 public void OnDrag(PointerEventData eventData)
 {
  if(transform.parent == originalParent5) return;
   transform.position = eventData.position;

 }

 }

