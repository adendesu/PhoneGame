using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ButtleCharacterStatus : MonoBehaviour,ISurveDamageMessage
{
    [System.NonSerialized] public int stageNumber;

    [System.NonSerialized] public int max;
    [System.NonSerialized] public ReactiveProperty<float> hp = new ReactiveProperty<float>(0);
    [System.NonSerialized] public ReactiveProperty<int> attack = new ReactiveProperty<int>(1);
    [System.NonSerialized] public ReactiveProperty<int> defense = new ReactiveProperty<int>(0);

   public void ApplyDamage(int ATK,float skill)
    {
        int damage = (ATK / 2) - (defense.Value / 4);
        hp.Value -= damage * skill;
    }



}