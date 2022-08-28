using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Card {
  public int id;
  public string cardName;
  public int cost;
  public int levelpower;
  public string cardDescriptiongood;
  public string cardDescriptionbad;
  public int ex;


  public Sprite thisImage;

  public string color;

 
public Card()
{

}


public Card (int Id, string CardName, int Cost, int Levelpower, string CardDescriptiongood, string CardDescriptionbad, int Ex, Sprite ThisImage, string Color){

id = Id;
cardName = CardName;
cost= Cost;
levelpower = Levelpower;
cardDescriptiongood = CardDescriptiongood;
cardDescriptionbad = CardDescriptionbad;
ex= Ex;

thisImage = ThisImage;

color = Color;


}





}









