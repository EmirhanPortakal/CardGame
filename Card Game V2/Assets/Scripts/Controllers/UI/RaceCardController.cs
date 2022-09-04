using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class RaceCardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler



{
    public CardRace cardrace;
    public Image illustration3, image;
    public TextMeshProUGUI cardName3, raceStuff,raceName;
    private Transform originalParent3;
   private void Awake()
   {
    image = GetComponent<Image>();
   


   }  
  private  void Start()
    {
      



        
    }
 public void Initialize(CardRace cardrace)
 {
  this.cardrace = cardrace; 

 illustration3.sprite = cardrace.illustration3;
 cardName3.text = cardrace.cardName3;
 raceStuff.text = cardrace.raceStuff;
 raceName.text = cardrace.raceName;
 originalParent3 = transform.parent;



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
  if(originalParent3.name == $"PlayableArea2")
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
      if(PlayerManager.instance.FindPlayerByID(cardrace.ownerID).movemana >= cardrace.cardMovemana)
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
    originalParent3 = playArea;
    transform.localPosition = Vector3.zero; 



   }


   public void PlayCardRace()
   {

   }

   public void ReturnToHand()
   {
    transform.SetParent(originalParent3);
    transform.localPosition = Vector3.zero; 


   }

 public void OnDrag(PointerEventData eventData)
 {
  if(transform.parent == originalParent3) return;
   transform.position = eventData.position;

 }

 }

