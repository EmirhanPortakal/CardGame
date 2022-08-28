using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class PlayerDeck : MonoBehaviour
{



 public List<Card> deck = new List<Card>();
 public List<Card> container = new List<Card>();

 public int randomIndex;
 public int x;
 public int deckSize;
 public int cardid;

 public GameObject Cards;
 public GameObject CardBack;
 public GameObject Deck;
 public GameObject[] Clones;
    
    void Start()
    {

      x= 0;
      deckSize =  CardDataBase.cardList.Count;
      for(int i=0;i<deckSize;i++)
      {
        x= Random.Range(1,  CardDataBase.cardList.Count );
       //s deck[i]=CardDataBase.cardList[x];
      }
  

    }

 
    void Update()
    {
       //if(deckSize<1)
       //{

       // cardInDeck1.SetActive(false);
       //} 
       //if(deckSize<2){

       // cardInDeck2.SetActive(false);
       //} 
       //if(deckSize<3){

       // cardInDeck3.SetActive(false);
       //} 
       //if(deckSize<4){

       // cardInDeck4.SetActive(false);
       //} 
       //if(deckSize<5){

       // cardInDeck5.SetActive(false);
       //} 
       //if(deckSize<6){

       // cardInDeck6.SetActive(false);
       //} 
    }

    IEnumerator Example()
    {
      yield return new WaitForSeconds(1);
      Clones = GameObject.FindGameObjectsWithTag("Clone");


      foreach(GameObject Clone in  Clones)
      {
        Destroy(Clone);


      }
      
    }


    public void Shuffle()
    {
      
      for(int i = 0;i< deckSize;i++)
      {
      
        container[0] = deck[i];
        randomIndex = Random.Range(i, deckSize);
        deck[i] = deck[randomIndex];


        deck[randomIndex] = container[0];
        //Debug.Log(randomIndex);


      }
        cardid = deck[0].id;
        //Debug.Log(cardid);
        Instantiate(CardBack, transform.position, transform.rotation);
        StartCoroutine(Example());
 
    } 
    
 
  
}
