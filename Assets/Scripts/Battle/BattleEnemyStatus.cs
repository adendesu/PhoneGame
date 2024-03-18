using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
    
public class BattleEnemyStatus : MonoBehaviour
{
    public ReactiveProperty<float> hp = new ReactiveProperty<float>(1);
    public ReactiveProperty<int> attack = new ReactiveProperty<int>(1);
    public ReactiveProperty<int> deffence = new ReactiveProperty<int>(1);

}
