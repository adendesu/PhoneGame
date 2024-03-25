using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UniRx;
public class BattleCharacterStatusModel : MonoBehaviour
{
   private GameObject[] playerCharacter;
   private GameObject[] enemyCharacter;

   public ReactiveProperty<int> characterCount = new ReactiveProperty<int>(0);
   public ReactiveProperty<int> enemyCount = new ReactiveProperty<int>(0);
   

   public void DeathMotion(string objectTagName, int number)
   {
      
      if (playerCharacter == null)
      {
         GetCharacter();
      }

      if (enemyCharacter == null)
      {
         GetEnemy();
      }

      if (objectTagName == "character")
      {
         
      }
      else if(objectTagName == "enemy")
      {
         Destroy(enemyCharacter[number]); 
         GetEnemy();
      }
      
      
   }
   
   void GetCharacter()
   {
      playerCharacter = GameObject.FindGameObjectsWithTag("character");
      characterCount.Value = playerCharacter.Length;
   }

   void GetEnemy()
   {
      enemyCharacter = GameObject.FindGameObjectsWithTag("enemy"); ;
      enemyCount.Value = enemyCharacter.Length;
   }
}
