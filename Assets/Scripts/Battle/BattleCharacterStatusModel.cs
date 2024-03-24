using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BattleCharacterStatusModel : MonoBehaviour
{
   private GameObject[] playerCharacter;
   private GameObject[] enemyCharacter;


   public void DeathMotion(int number)
   {
      if (playerCharacter == null)
      {
         GetCharacter();
      }

      if (enemyCharacter == null)
      {
         GetEnemy();
      }
      
      
      
   }
   
   void GetCharacter()
   {
      playerCharacter = GameObject.FindGameObjectsWithTag("character");
   }

   void GetEnemy()
   {
      enemyCharacter = GameObject.FindGameObjectsWithTag("enemy"); ;
   }
}
