using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class CardDataBase : MonoBehaviour
{
 public static List<Card> cardList = new List<Card> ();


 void Awake(){

    cardList.Add(new Card(0, "None", 0, 0, "None", "none", 0, Resources.Load <Sprite>("0"), "none"));
    cardList.Add(new Card(1, "Human", 2, 100, "This is a good", "this is bad", 1, Resources.Load <Sprite>("1"), "Red"));
    cardList.Add(new Card(2, "Elf", 3, 200, "This is a Elf", "elf bad", 2, Resources.Load <Sprite>("2"), "Blue"));
    cardList.Add(new Card(3, "Dwarfs", 4, 300, "This is a Dwarfs", "dwarfs bad", 3, Resources.Load <Sprite>("3"), "Yellow"));
    cardList.Add(new Card(4, "Troll", 5, 400, "This is a Troll", "troll bad", 4, Resources.Load <Sprite>("4"), "Purple")); 
    cardList.Add(new Card(5, "Goblin", 6, 500, "This is a Goblin", "Goblin bad", 5, Resources.Load <Sprite>("5"), "Green"));
 }
}
