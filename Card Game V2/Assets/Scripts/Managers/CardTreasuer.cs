using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardTreasuer : MonoBehaviour, IPointerDownHandler
{
    ShuffleManager cs;
    public GameObject obje;

   // IEnumerator randomtriger;

   void Start(){

    cs = obje.GetComponent<ShuffleManager>();
   }


   public void OnPointerDown(PointerEventData eventData)
	 {


		/*randomtriger = cs.RandomShuffle();
		StartCoroutine(randomtriger);
        Debug.Log("BASTI");
		*/

       cs.RandomShuffle();



	 }
}
