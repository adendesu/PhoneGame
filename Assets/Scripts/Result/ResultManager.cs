using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class ResultManager : MonoBehaviour
{
    // Start is called before the first frame update
    async UniTask Start()
    {
       await GetBattleStageData();
    }
    
    protected virtual async UniTask  GetBattleStageData(){}
}
