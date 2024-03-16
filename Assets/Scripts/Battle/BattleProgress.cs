using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class BattleProgress : MonoBehaviour
{
    Queue<int> battleTask;
    GameObject[] playerCharacter;
    GameObject[] EnemyCharacter;

    int battleCharacters = 0;

    int characterMax = 0;
    int enemyMax = 0;

    int characterCount = 0;
    int enemyCount = 0;

    int eNum = 0;

    int task;
    // Start is called before the first frame update
   async UniTask Start()
    {
        await GetCharacter();
        await GetEnemy();
    }

    // Update is called once per frame
    async UniTask Update()
    {
        
        if (battleTask?.Peek() == null)
        {
            
            
        }
        else
        {
            if (characterCount < characterMax)
            {
                battleTask.Enqueue(0);
            }
            else if (enemyCount < enemyMax)
            {
                battleTask.Enqueue(1);
            }
        }

        switch (battleTask.Dequeue())
        {
            case 0:
                await WeekAttack(characterCount, EnemyCharacter[eNum]);
                characterCount++;
                    break;
            case 1:
                await EnemyAttack(enemyCount, Random.Range(0, playerCharacter.Length));
                    break;



        }
        if (characterCount > characterMax)
        {
            characterCount = 0;
        }
        
    }
    async UniTask WeekAttack(int i,GameObject target)
    {
        playerCharacter[i].GetComponent<BasisCharacter>().NomalAttack(target);
    }
    async UniTask EnemyAttack(int i, int targetNum)
    {
        GameObject target = playerCharacter[targetNum];
        playerCharacter[i].GetComponent<BasisCharacter>().NomalAttack(target);
    }

    async UniTask GetCharacter()
    {
        playerCharacter = GameObject.FindGameObjectsWithTag("character");
        characterMax = playerCharacter.Length;
    }

    async UniTask GetEnemy()
    {
       EnemyCharacter = GameObject.FindGameObjectsWithTag("enemy");
        enemyMax = EnemyCharacter.Length;
    }

}
