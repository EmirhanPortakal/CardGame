using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler

// IPointerEnterHandler, IPointerExitHandler çıkarıldı kullanılmadığı için hem hata veriyor hemde boşuna ram yiyor.

{
    public Card card;
    public Image illustration, image;
    public TextMeshProUGUI cardName, goodstuff, badstuff, level, treasure, ex;
    private Transform originalParent;
    GameManager gm;


    public int handIndex;
    public bool hasBeenPlayed;
   private void Awake()
   {
    image = GetComponent<Image>();
    gm = FindObjectOfType<GameManager>();
   }
   private void Start(){
    //başladıklarında destede başlasınlar
    transform.SetParent(GameObject.Find("Player1Hand").transform);
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
  //  public void OnPointerEnter(PointerEventData eventData)
  //  {
    
  //  }
   public void OnMouseOver(PointerEventData eventData){
    Debug.Log("mouse girdi");
   }
  //  public void OnPointerExit(PointerEventData eventData)
  //  {
    

  //  }
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

	void MoveToDiscardPile()
	{
		gm.discardPile.Add(this);
		gameObject.SetActive(false);
    Debug.Log("Discarded");
	}


 public void OnPointerUp(PointerEventData eventData)
 {
   Debug.Log(eventData.pointerEnter);
  image.raycastTarget = true;
  AnalyzePointerUp(eventData);

 
 }

 private void AnalyzePointerUp(PointerEventData eventData)
   {  
    
    if(eventData.pointerEnter != null && eventData.pointerEnter.name == $"PlayableArea")
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
    Invoke("MoveToDiscardPile", 1f);


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
