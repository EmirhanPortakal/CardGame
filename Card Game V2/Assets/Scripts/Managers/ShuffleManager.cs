using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ShuffleManager : MonoBehaviour
{
   /* public List<CardController> deck;
	public TextMeshProUGUI deckSizeText;

	public Transform[] cardSlots;
    public Transform Parent;
	public bool[] availableCardSlots;

	public List<CardController> discardPile;
	public TextMeshProUGUI discardPileSizeText;

	public void DrawCard()
	{
        
		if (deck.Count >= 1)
		{
           

			CardController randomCard = deck[Random.Range(0, deck.Count)];
			for (int i = 0; i < availableCardSlots.Length; i++)
			{
				if (availableCardSlots[i] == true)
				{
					//randomCard.gameObject.SetActive(true);
                    Instantiate(randomCard);
                    //randomCard.transform.SetParent(GameObject.Find("Player1Hand").transform);
					randomCard.handIndex = i;
					randomCard.transform.position = cardSlots[i].position;
					randomCard.hasBeenPlayed = false;
					deck.Remove(randomCard);
					availableCardSlots[i] = false;
					return;
				}
			}
		}
	}

	public void Shuffle()
	{
        
		if (discardPile.Count >= 1)
		{
            Debug.LogWarning("Shuffled.");
			foreach (CardController card in discardPile)
			{
				deck.Add(card);
			}
			discardPile.Clear();
		}
	}

	private void Update()
	{
		deckSizeText.text = deck.Count.ToString();
		discardPileSizeText.text = discardPile.Count.ToString();
	}
	*/

    
    public static CardManager instance;
    public List<Card> cards = new List<Card>();
    public List<CardClass> classcards = new List<CardClass>();
    public List<CardRace> racecards = new List<CardRace>();
    public List<CardItem> itemcards = new List<CardItem>();
    public List<CardCurse> cursecards = new List<CardCurse>();

    public Transform  PlayableArea;

    public CardController cardControllerPreFab;
    public ClassCardController cardControllerPreFab2;
    public RaceCardController cardControllerPreFab3;
    public ItemCardController cardControllerPreFab4;
    public CurseCardController cardControllerPreFab5;

	int randomchildnumber;
    IEnumerator randomtriger;

	
    


   private void Awake()
    {
          
	

	}

    private void Start()
    {
		
		
        GenerateCards();
        GenerateClassCards();
        GenerateRaceCards();
        GenerateItemCards();
        GenerateCurseCards();
		
        
    }

	

	 public void RandomShuffle()
	 {    


			//yield return new WaitForSeconds(1f);
		 foreach (Transform PlayableArea in transform.parent) 
		   {        
                // Debug.Log (PlayableArea.transform.childCount);
				
            }
		
		int randomNumber = Random.Range(0,PlayableArea.transform.childCount);

		randomchildnumber = randomNumber;
		GetChilds();

		
		

	 }


	 public void GetChilds(){
	
	


		Transform childcard = transform.GetChild(randomchildnumber);
		Debug.Log(childcard.name);
		
		childcard.transform.position += Vector3.up * 120f;
	 }

	  


     private void GenerateCards()
    {

       foreach (Card card in cards)
        {
            CardController newCard = Instantiate(cardControllerPreFab,PlayableArea);
            //newCard.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard.Initialize(card);
        }

    }
    private void GenerateClassCards()
    {
         foreach (CardClass cardclass in classcards)
        {
            ClassCardController newCard2 = Instantiate(cardControllerPreFab2, PlayableArea);
            newCard2.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard2.Initialize(cardclass);
        }

    }

      private void GenerateRaceCards()
    {
         foreach (CardRace cardrace in racecards)
        {
            RaceCardController newCard3 = Instantiate(cardControllerPreFab3, PlayableArea);
            newCard3.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard3.Initialize(cardrace);
        }

    }


      private void GenerateItemCards()
    {
         foreach (CardItem carditem in itemcards)
        {
           ItemCardController newCard4 = Instantiate(cardControllerPreFab4, PlayableArea);
            newCard4.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard4.Initialize(carditem);
        }

    }

      private void GenerateCurseCards()
    {
         foreach (CardCurse cardcurse in cursecards)
        {
           CurseCardController newCard5 = Instantiate(cardControllerPreFab5,PlayableArea);
            newCard5.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard5.Initialize(cardcurse);
        }

    }







}




