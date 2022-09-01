using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ClassCardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler



{
    public CardClass cardclass;
    public Image illustration2, image;
    public TextMeshProUGUI cardName2, classStuff,className;
    private Transform originalParent2;
   private void Awake()
   {
    image = GetComponent<Image>();
   


   }  
  private  void Start()
    {
      



        
    }
 public void Initialize(CardClass cardclass)
 {
  this.cardclass = cardclass; 

 illustration2.sprite = cardclass.illustration2;
 cardName2.text = cardclass.cardName2;
 classStuff.text = cardclass.classStuff;
 className.text = cardclass.className;
 originalParent2 = transform.parent;



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
  if(originalParent2.name == $"PlayableArea2")
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
      if(PlayerManager.instance.FindPlayerByID(cardclass.ownerID).movemana >= cardclass.cardMovemana)
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
    originalParent2 = playArea;
    transform.localPosition = Vector3.zero; 



   }


   public void PlayCardClass()
   {

   }

   public void ReturnToHand()
   {
    transform.SetParent(originalParent2);
    transform.localPosition = Vector3.zero; 


   }

 public void OnDrag(PointerEventData eventData)
 {
  if(transform.parent == originalParent2) return;
   transform.position = eventData.position;

 }

 }

