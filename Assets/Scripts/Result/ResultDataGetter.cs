using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class ResultDataGetter : ResultManager
{
    protected override UniTask GetBattleStageData()
    {
        GameObject battleDataObject = GameObject.FindGameObjectWithTag("EnemyData");
        
    }

    
}
