using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ButtleCharacterStatus : MonoBehaviour
{
    private GameObject thisGameObject;
        
    [System.NonSerialized] public int stageNumber;

    [System.NonSerialized] public int max;
    [System.NonSerialized] public ReactiveProperty<float> hp = new ReactiveProperty<float>(0);
    [System.NonSerialized] public ReactiveProperty<int> attack = new ReactiveProperty<int>(1);
    [System.NonSerialized] public ReactiveProperty<int> defense = new ReactiveProperty<int>(0);

   public  ButtleCharacterStatus(GameObject obj,int i, int m, float h, int a, int d)
   {
       thisGameObject = obj;
        stageNumber = i;
        max = m;
        hp.Value = h;
        attack.Value = a;
        defense.Value = d;
    }

}