using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Unity.VisualScripting;
using Sequence = DG.Tweening.Sequence;

public class BattleProgress : MonoBehaviour
{
    Queue<int> battleTask = new Queue<int>();
    GameObject[] playerCharacter;
    GameObject[] enemyCharacter;

    int battleCharacters = 0;

    int characterMax = 0;
    int enemyMax = 0;

    int characterCount = 0;
    int enemyCount = 0;

    int eNum = 0;

    int task;

    private bool canBattle = false;
    // Start is called before the first frame update
   async UniTask Start()
    {
        UniTask.WaitForSeconds(1);
         GetCharacter();
         GetEnemy();
         Sequence sequence = DOTween.Sequence();
         sequence.AppendInterval(3)
             .OnComplete( () => Progress());
          
    }

    // Update is called once per frame
    async  UniTask Progress()
    {
       // if (canBattle)
       // {

       
       while(true){
           if (battleTask.Count == 0)
           {
               if (characterCount < characterMax)
               {
                   battleTask.Enqueue(1);
                   
               }
               else if (enemyCount < enemyMax)
               {
                   battleTask.Enqueue(2);
                   
               }
           }

           switch (battleTask.Dequeue())
           {
               case 1:
                   await WeekAttack(characterCount, enemyCharacter[eNum]);
                   characterCount++;


                   break;
               case 2:
                   await EnemyAttack(enemyCount, Random.Range(0, characterCount));
                   enemyCount++;


                   break;



           }

           if (characterCount == characterMax && enemyCount == enemyMax)
           {
               characterCount = 0;
               enemyCount = 0;
           }

           UniTask.Delay(300);
       }
       //  }
    }
    async UniTask WeekAttack(int i,GameObject target)
    {
        playerCharacter[i].GetComponent<BasisCharacter>().NomalAttack(target);
       
        await UniTask.Delay(3000);
    }
    async UniTask EnemyAttack(int i, int targetNum)
    {
        GameObject target = playerCharacter[targetNum];
        enemyCharacter[i].GetComponent<BasisCharacter>().NomalAttack(target);
        Debug.Log(targetNum);
        await UniTask.Delay(3000);
    }

    void GetCharacter()
    {
        playerCharacter = GameObject.FindGameObjectsWithTag("character");
        characterMax = playerCharacter.Length;
    }

    void GetEnemy()
    {
       enemyCharacter = GameObject.FindGameObjectsWithTag("enemy");
        enemyMax = enemyCharacter.Length;
    }

}
