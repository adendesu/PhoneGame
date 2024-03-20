using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "enemyList")]
public class EnemyDatas : ScriptableObject
{
    public List<EnemyStatus> enemyStatuses;
}
