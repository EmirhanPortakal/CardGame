using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Player
{
    
   public int playerlevel, movemana;
   public int ID;
   public bool myTurn;
   
   public Player(int playerlevel, int ID, int movemana)
   {
      this.playerlevel = playerlevel;
      this.ID = ID;
      this.movemana = movemana;




   }




}
