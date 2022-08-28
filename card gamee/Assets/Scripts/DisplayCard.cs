using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class DisplayCard : MonoBehaviour
{

    public List<Card> displayCard = new List<Card>();
    //public GameObject PlayerDeck;


    public GameObject Card;

    public int displayId;
    public int id;
    public string cardName;
    public int cost;
    public int levelpower;
    public string cardDescriptiongood;
    public string cardDescriptionbad;
    public int ex;

    public Text nameText;
    public Text costText;
    public Text levelpowerText;
    public Text cardDescriptiongoodText;
    public Text cardDescriptionbadText;
    public Text exText;


    public Sprite thisSprite;
    public Image thatImage;

    public Image frame;
    public bool cardBack;
    public static bool staticCardBack;


    void Start()
    {

        //displayCard[0]  = CardDataBase.cardList[displayId];
        // for(int i = 0; i< CardDataBase.cardList.Count; i++)
        // {
        //     displayCard[i] = CardDataBase.cardList[i];
        // }
        

    }

    public void ShowCard(int id)
    {
        // displayCard[id] = CardDataBase.cardList[id];
        // id = displayCard[id].id;
        // cardName = displayCard[id].cardName;
        // cost = displayCard[id].cost;
        // levelpower = displayCard[id].levelpower;
        // cardDescriptiongood = displayCard[id].cardDescriptiongood;
        // cardDescriptionbad = displayCard[id].cardDescriptionbad;
        // ex = displayCard[id].ex;

        // thisSprite = displayCard[id].thisImage;
        GameObject card = Instantiate(Card, transform.position, transform.rotation);
        card.transform.Find("Border").GetChild(0).GetChild(0).GetComponent<TextMeshPro>().text = "Level : 1";
        card.transform.Find("NameText").GetComponent<TextMeshPro>().text = "Eld";
        // Card.transform.SetParent(Canvas.transform, false);
        // transform.Find("Border").GetChild(0).GetChild(0).GetComponent<TextMeshPro>().text = "Level : 1";
        // transform.Find("NameText").GetComponent<TextMeshPro>().text = "Eld";


    }


    void Update()

    {
        if(GameObject.FindGameObjectWithTag("Card") != false){
            GameObject.FindGameObjectWithTag("Card").transform.SetParent(GameObject.Find("Canvas").transform, false);   
        }
        
        
        //PlayerDeck playerDeck = PlayerDeck.GetComponent<PlayerDeck>();
        //playerDeck.cardid = displayId;
        // Debug.Log(playerDeck.cardid);
        //PlayerDeck.GetComponent<PlayerDeck>().cardid = cardID;
        // Debug.LogWarning(cardID);
        
        //displayCard[0] = CardDataBase.cardList[displayId];
        //id = displayCard[0].id;
        //cardName = displayCard[0].cardName;
        //cost = displayCard[0].cost;
        //levelpower = displayCard[0].levelpower;
        //cardDescriptiongood = displayCard[0].cardDescriptiongood;
        //cardDescriptionbad = displayCard[0].cardDescriptionbad;
        //ex = displayCard[0].ex;

        //thisSprite = displayCard[0].thisImage;





        //nameText.text = " " + cardName;
        //costText.text = " " + cost;
        //levelpowerText.text = " " + levelpower;
        //cardDescriptiongoodText.text = " " + cardDescriptiongood;
        //cardDescriptionbadText.text = " " + cardDescriptionbad;
        //exText.text = " " + ex;

        //thatImage.sprite = thisSprite;

        //switch (displayCard[0].color)
        //{
        //    case "Red":
        //        frame.GetComponent<Image>().color = new Color32(148, 60, 60, 255);
        //        break;

        //    case "Blue":
        //        frame.GetComponent<Image>().color = new Color32(81, 112, 214, 255);
        //        break;

        //    case "Yellow":
        //        frame.GetComponent<Image>().color = new Color32(214, 187, 81, 255);
        //        break;

        //    case "Purple":
        //        frame.GetComponent<Image>().color = new Color32(107, 62, 126, 255);
        //        break;

        //    case "Green":
        //        frame.GetComponent<Image>().color = new Color32(0, 128, 0, 255);
        //        break;

        //    default:
        //        frame.GetComponent<Image>().color = new Color32(30, 30, 30, 255);
        //        break;
        //}
        //staticCardBack = cardBack;

    }
}
