using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler



{
    public Card card;
    public Image illustration, image;
    public TextMeshProUGUI cardName, goodstuff, badstuff, level, treasure, ex;
    private Transform originalParent;
   private void Awake()
   {
    image = GetComponent<Image>();
   


   }  
  private  void Start()
    {
      



        
    }
 public void Initialize(Card card)
 {
  this.card = card; 

 illustration.sprite = card.illustration;
 cardName.text = card.cardName;
 goodstuff.text = card.goodstuff;
 badstuff.text = card.badstuff;
 level.text = card.level.ToString();
 treasure.text = card.treasure.ToString();
 ex.text = card.ex.ToString();
 originalParent = transform.parent;



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
  if(originalParent.name == $"PlayableArea")
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
    
    if(eventData.pointerEnter != null && eventData.pointerEnter.name == $"PlayableArea" | eventData.pointerEnter.name == "Player2Hand")
    
    {
      if(PlayerManager.instance.FindPlayerByID(card.ownerID).movemana >= card.cardMovemana)
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
    originalParent = playArea;
    transform.localPosition = Vector3.zero; 



   }


   public void PlayCard()
   {

   }

   public void ReturnToHand()
   {
    transform.SetParent(originalParent);
    transform.localPosition = Vector3.zero; 


   }

 public void OnDrag(PointerEventData eventData)
 {
  if(transform.parent == originalParent) return;
   transform.position = eventData.position;

 }

 }
