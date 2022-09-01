using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager instance;
    public List<Player> players = new List<Player>();

    private void Awake ()
    {
        instance = this;

    }
    internal void AssignTurn(int currentPlayerTurn)
    {   
          foreach (Player player in players)
        {
           player.myTurn = player.ID == currentPlayerTurn;
           
         
        }

        FindPlayerByID(currentPlayerTurn).myTurn = true;
       
    }

    public Player FindPlayerByID(int ID)
    {
        Player foundPlayer = null;

        foreach( Player player in players)
        {
            foundPlayer = player;

        }
       

        return foundPlayer;


       // Player player  = players.Find(x => x.ID == currentPlayerTurn);
        //player.myTurn = true;

    }

    
}
