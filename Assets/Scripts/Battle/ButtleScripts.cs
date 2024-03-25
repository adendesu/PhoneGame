using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class ButtleScripts : ButtleManager
{
   /*[System.NonSerialized]*/ public static ButtleCharacterStatus[] buttleCharacterStatus = new ButtleCharacterStatus[3];
    [SerializeField] ButtleCharacterView buttleCharacterView;
    List<(int number, ButtleCharacterStatus status)> statusTuple;

   [SerializeField] private BattleCharacterStatusModel battleCharacterStatusModel;

   [SerializeField] private BattleProgress battleProgress;
    // Start is called before the first frame update

    private void Awake()
    {
        battleCharacterStatusModel.characterCount.Subscribe(_ => battleProgress.GetCharacter());
        battleCharacterStatusModel.enemyCount.Subscribe(_ => battleProgress.GetEnemy());

    }
    // Update is called once per frame

   public void SendCharacterView(int number, Sprite sp, string n)
    {
        buttleCharacterView.SetCharacterView(number, sp, n);

    }

    public void SendDisView(int number)
    {
        buttleCharacterView.DisDisplay(number);

    }
    public void SetCharacterView(int number, float hp, int max)
    {
        buttleCharacterView.DisplayCharacterView(number, hp, max);
       
    }

    public void SendDeathMotion(string tagName,int i)
    {
        battleCharacterStatusModel.DeathMotion(tagName,i);
    }
}
