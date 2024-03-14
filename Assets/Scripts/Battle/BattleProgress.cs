using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class BattleProgress : MonoBehaviour
{
    Queue<int> battleTask;
    GameObject[] playerCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    async UniTask WeekAttack()
    {

    }

    void GetCharacter()
    {
        playerCharacter = GameObject.FindGameObjectsWithTag("character");

    }
    
}
