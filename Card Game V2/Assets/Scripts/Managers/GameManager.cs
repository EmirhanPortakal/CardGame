using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<CardController> deck;
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
}
