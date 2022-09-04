using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager: MonoBehaviour
{
    public static CardManager instance;
    public List<Card> cards = new List<Card>();
    public List<CardClass> classcards = new List<CardClass>();
    public List<CardRace> racecards = new List<CardRace>();
    public List<CardItem> itemcards = new List<CardItem>();
    public List<CardCurse> cursecards = new List<CardCurse>();

    public Transform player1Hand, player2Hand, player3Hand, player4Hand;

    public CardController cardControllerPreFab;
    public ClassCardController cardControllerPreFab2;
    public RaceCardController cardControllerPreFab3;
    public ItemCardController cardControllerPreFab4;
    public CurseCardController cardControllerPreFab5;
    
    


    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        GenerateCards();
        GenerateClassCards();
        GenerateRaceCards();
        GenerateItemCards();
        GenerateCurseCards();
        

    }
    private void GenerateCards()
    {

       foreach (Card card in cards)
        {
            CardController newCard = Instantiate(cardControllerPreFab, player1Hand, player2Hand);
            newCard.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard.Initialize(card);
        }

    }
    private void GenerateClassCards()
    {
         foreach (CardClass cardclass in classcards)
        {
            ClassCardController newCard2 = Instantiate(cardControllerPreFab2, player1Hand, player2Hand);
            newCard2.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard2.Initialize(cardclass);
        }

    }

      private void GenerateRaceCards()
    {
         foreach (CardRace cardrace in racecards)
        {
            RaceCardController newCard3 = Instantiate(cardControllerPreFab3, player1Hand, player2Hand);
            newCard3.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard3.Initialize(cardrace);
        }

    }


      private void GenerateItemCards()
    {
         foreach (CardItem carditem in itemcards)
        {
           ItemCardController newCard4 = Instantiate(cardControllerPreFab4, player1Hand, player2Hand);
            newCard4.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard4.Initialize(carditem);
        }

    }

      private void GenerateCurseCards()
    {
         foreach (CardCurse cardcurse in cursecards)
        {
           CurseCardController newCard5 = Instantiate(cardControllerPreFab5, player1Hand, player2Hand);
            newCard5.transform.localPosition = Vector3.zero;
            // newCard.transform.localPosition = GameObject.Find("konum").transform.position;
            newCard5.Initialize(cardcurse);
        }

    }

}
