using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ItemCardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler



{
    public CardItem carditem;
    public Image illustration4, image;
    public TextMeshProUGUI cardName4, itemtype,itemcost,itembonuspower;
    private Transform originalParent4;
   private void Awake()
   {
    image = GetComponent<Image>();
   


   }  
  private  void Start()
    {
      



        
    }
 public void Initialize(CardItem carditem)
 {
  this.carditem = carditem; 

 illustration4.sprite = carditem.illustration4;
 cardName4.text = carditem.cardName4;
 itemtype.text = carditem.itemtype;
 itemcost.text = carditem.itemcost.ToString();
 itembonuspower.text = carditem.itembonuspower.ToString();



 originalParent4 = transform.parent;



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
  if(originalParent4.name == $"PlayableArea2")
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
      if(PlayerManager.instance.FindPlayerByID(carditem.ownerID).movemana >= carditem.cardMovemana)
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
    originalParent4 = playArea;
    transform.localPosition = Vector3.zero; 



   }


   public void PlayCardItem()
   {

   }

   public void ReturnToHand()
   {
    transform.SetParent(originalParent4);
    transform.localPosition = Vector3.zero; 


   }

 public void OnDrag(PointerEventData eventData)
 {
  if(transform.parent == originalParent4) return;
   transform.position = eventData.position;

 }

 }

